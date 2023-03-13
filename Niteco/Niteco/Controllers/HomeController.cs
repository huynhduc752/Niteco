using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Niteco.Models;
using Niteco.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Niteco.Controllers
{
    public class HomeController : Controller
    {
        private readonly NitecoContext _dbContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,
            NitecoContext dbContext)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var result = (from O in _dbContext.Orders
                          join P in _dbContext.Products on O.ProductId equals P.Id
                          join C in _dbContext.Categories on P.CategoryId equals C.Id
                          select new OrderViewModel
                          {
                              Id = O.Id,
                              Name = P.Desc,
                              Title = C.Title,
                          }).ToList();
            return View(result);
        }

        public IActionResult Privacy()
        {
            CommonViewModel common = new CommonViewModel();
            common.Category = _dbContext.Categories.ToList();
            common.Product = _dbContext.Products.ToList();
            common.Customer = _dbContext.Customers.ToList();
            return View(common);
        }

        [HttpPost]
        public IActionResult AddOrUpdate([FromBody] Order model)
        {
            _logger.LogInformation("AddOrUpdate:..", model);
            if (model.Id == 0)
            {
                var par = new Order
                {
                    ProductId = model.ProductId,
                    CustomerId = model.CustomerId,
                    Amount = model.Amount,
                    Desc = model.Desc,
                    CreatedDate = model.CreatedDate,
                };
                _dbContext.Orders.Add(par);
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
                    par.CreatedDate = model.CreatedDate;
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
