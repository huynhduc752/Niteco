using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Niteco.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Niteco.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ILogger<CustomerController> _logger;
        private readonly NitecoContext _dbContext;
        public CustomerController(ILogger<CustomerController> logger, NitecoContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddOrUpdate([FromBody] Customer model)
        {
            _logger.LogInformation("AddOrUpdate Customer:..", model);
            if (model.Id == 0)
            {
                var par = new Customer
                {
                    Name = model.Name,
                    Address = model.Address,
                    CreatedDate = DateTime.Now,
                    Desc = model.Desc,
                };
                _dbContext.Customers.Add(par);
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
                var par = _dbContext.Customers.Find(model.Id);
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
                    par.Name = model.Name;  
                    par.Desc = model.Desc;
                    par.Address = model.Address;
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
