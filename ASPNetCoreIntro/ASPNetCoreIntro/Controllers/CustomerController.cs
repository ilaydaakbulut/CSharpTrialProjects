using ASPNetCoreIntro.Entities;
using ASPNetCoreIntro.Models;
using ASPNetCoreIntro.Services.Logging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreIntro.Controllers
{
    [Route(template:"deneme")]
    public class CustomerController : Controller
    {
        private ILogger _logger;
        public CustomerController(ILogger logger)
        {
            _logger = logger;
        }
        [Route(template:"index")]
        [Route(template:"")]
        [Route(template:"~/anasayfa")]
        public IActionResult Index3()
        {
            _logger.Log("");
            List<Customer> customers = new List<Customer>
            {
                new Customer{Id=1,FirstName="ilayda",LastName="akbulut",City="rize"},
                new Customer{Id=2,FirstName="melisa",LastName="gokmen",City="mugla"},
                new Customer{Id=3,FirstName="ecem",LastName="girgin",City="aydin"}
            };
            List<string> shops = new List<string> { "ankara", "istanbul", "izmir" };
            var model = new CustomerListViewModel
            {
                Customers = customers,
                Shops = shops
            };
            return View(model);
        }
        [HttpGet]
        [Route(template:"save")]
        public IActionResult SaveCustomer()
        {
            return View(new SaveCustomerViewModel 
            { 
                Cities = new List<SelectListItem>
                {
                    new SelectListItem{Text="ankara",Value="06"},
                    new SelectListItem{Text="istanbul",Value="34"},
                    new SelectListItem{Text="izmir",Value="35"}
                } 
            }); 
        }
        [HttpPost]
        [Route(template: "save")]
        public string SaveCustomer(Customer customer) 
        {
            return "kaydedildi";
        }
    }
}
