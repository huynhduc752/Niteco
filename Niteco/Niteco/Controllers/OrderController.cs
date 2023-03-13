using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Niteco.Common;
using Niteco.Models;
using Niteco.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Niteco.Controllers
{
    public class OrderController : Controller
    {
        private readonly NitecoContext _dbContext;
        private readonly ILogger<OrderController> _logger;
        public OrderController(ILogger<OrderController> logger,
           NitecoContext dbContext)
        {
            _dbContext = dbContext;
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddOrder()
        {
            CommonViewModel common = new CommonViewModel();
            common.Category = _dbContext.Categories.ToList();
            common.Product = _dbContext.Products.ToList();
            common.Customer = _dbContext.Customers.ToList();
            return View(common);
        }
       public int PrecheckAmount(int? Id, int? amount)
        {
            var result = (from p in _dbContext.Products
                          where p.Id == Id &&
                                 p.Amount >= amount
                          select p.Id).ToList();
            if (result == null || result.Count == 0)
                return -2;
            return 0;
        }
        [HttpPost]
        public IActionResult GetData([FromBody] RequestModel model)
        {
            var result = from O in _dbContext.Orders
                         join P in _dbContext.Products on O.ProductId equals P.Id
                         join C in _dbContext.Categories on P.CategoryId equals C.Id
                         select new OrderViewModel
                         {
                             Id = O.Id,
                             OrderName = O.Title,
                             ProductName = P.Name,
                             OrderAmount = O.Amount,
                             CateTitle = C.Title,
                             Price = P.Price,
                             Desc = O.Desc,
                          };
            var v_list = result.ToList();
            if(model != null)
            {
                if (!string.IsNullOrEmpty(model.Name))
                {
                    result = result.Where(x => x.OrderName == model.Name);
                }
                if (!string.IsNullOrEmpty(model.Price))
                {
                    result = result.Where(x => x.Price == Int32.Parse(model.Price));
                }
                if (!string.IsNullOrEmpty(model.Amount))
                {
                    result = result.Where(x => x.OrderAmount == Int32.Parse(model.Amount));
                }
            }

            return Json(result.ToList());
        }


        [HttpPost]
        public IActionResult AddOrUpdate([FromBody] Order model)
        {
            _logger.LogInformation("AddOrUpdate Order:..", model);

            int check = PrecheckAmount(model.ProductId, model.Amount);
            if (check < 0)
            {
                return Json(new
                {
                    status = "-2",
                    desc = "Số lượng ko hợp lệ"
                });
            }
           
            if (model.Id == 0)
            {
                var par = new Order
                {
                    ProductId = model.ProductId,
                    Title = model.Title,
                    CustomerId = model.CustomerId,
                    Amount = model.Amount,
                    Desc = model.Desc,
                    CreatedDate = DateTime.Now,
                };
                _dbContext.Orders.Add(par);

                var p = _dbContext.Products.Find(model.ProductId);
                p.Amount = p.Amount - model.Amount;

                var isSuccess = _dbContext.SaveChanges();
                if (isSuccess > 0)
                {
                    return Json(new
                    {
                        status = "0",
                        desc = "Thực hiện thành công"
                    });
                }
                else
                {
                    return Json(new
                    {
                        status = "-1",
                        desc = "Lỗi hệ thống"
                    });
                }

            }
            else
            {
                var par = _dbContext.Orders.Find(model.Id);
                if (par == null)
                {
                    return Json(new
                    {
                        status = "-1",
                        desc = "Lỗi hệ thống"
                    });
                }
                else
                {
                    par.ProductId = model.ProductId;
                    par.CustomerId = model.CustomerId;
                    par.Amount = model.Amount;
                    par.Desc = model.Desc;
                    par.Title = model.Title;
                    par.CreatedDate = DateTime.Now;
                    var isSuccess = _dbContext.SaveChanges();
                    if (isSuccess > 0)
                    {
                        return Json(new
                        {
                            status = "0",
                            desc = "Thực hiện thành công"
                        });
                    }
                    else
                    {
                        return Json(new
                        {
                            status = "-1",
                            desc = "Lỗi hệ thống"
                        });
                    }
                }
            }
        }
    }
}
