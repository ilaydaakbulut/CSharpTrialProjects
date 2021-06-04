using ASPNetCoreIntro.Entities;
using ASPNetCoreIntro.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreIntro.Controllers
{
    public class CustomerController:Controller
    {
        public IActionResult Index3()
        {
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
        public IActionResult SaveCustomer()
        {
            return View(new SaveCustomerViewModel());
        }
        [HttpPost]
        public string SaveCustomer(Customer customer)
        {
            return "kaydedildi";
        }
    }
}
