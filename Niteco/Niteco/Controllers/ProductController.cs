using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Niteco.Models;
using Niteco.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Niteco.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<OrderController> _logger;
        private readonly NitecoContext _dbContext;
        public ProductController(ILogger<OrderController>  logger, NitecoContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            CommonViewModel common = new CommonViewModel();
            common.Category = _dbContext.Categories.ToList();
            return View(common);
        }
        [HttpPost]
        public IActionResult AddOrUpdate([FromBody] Product model)
        {
            _logger.LogInformation("AddOrUpdate Customer:..", model);
            if (model.Id == 0)
            {
                var par = new Product
                {
                    CategoryId = model.CategoryId,
                    Name = model.Name,
                    Amount = model.Amount,
                    Desc = model.Desc,
                    Price = model.Price,
                    CreatedDate = DateTime.Now,
                };
                _dbContext.Products.Add(par);
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
                var par = _dbContext.Products.Find(model.Id);
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
                    par.CategoryId = model.CategoryId;
                    par.Name = model.Name;
                    par.Amount = model.Amount;
                    par.Desc = model.Desc;
                    par.Price = model.Price;
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
