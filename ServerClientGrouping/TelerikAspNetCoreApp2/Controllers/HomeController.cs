using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;
using TelerikAspNetCoreApp2.Models;

namespace TelerikAspNetCoreApp2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult ServerGrouping()
        {
            return View();
        }

        public IActionResult ClientGrouping()
        {
            return View();
        }

        public JsonResult GetProducts([DataSourceRequest]DataSourceRequest request)
        {
            var productss = ProductsAll().ToDataSourceResult(request);
            return Json(productss);
        }

        private List<ProductVM> ProductsAll()
        {
            var products = new List<ProductVM>()
            {
                new ProductVM(){ Id = 6,  TypeP="Fruit", Name = "Berries", Price = 10},
                new ProductVM(){ Id = 1,  TypeP="Fruit",  Name = "Appricot", Price = 10},
                new ProductVM(){ Id = 2,  TypeP="Fruit", Name = "Orange", Price = 10},
                new ProductVM(){ Id = 3,  TypeP="Fruit", Name = "Apple", Price = 10},
                new ProductVM(){ Id = 4,  TypeP="Fruit", Name = "Peach", Price = 10},
                new ProductVM(){ Id = 5,  TypeP="Fruit", Name = "Other Fruit", Price = 10},
                new ProductVM(){ Id = 7,  TypeP="Vegetable",  Name = "Tomato", Price = 10},
                new ProductVM(){ Id = 8,  TypeP="Vegetable",  Name = "Cabbage", Price = 10},
                new ProductVM(){ Id = 9,  TypeP="Vegetable",  Name = "Carrot", Price = 10},
                new ProductVM(){ Id = 10, TypeP="Vegetable",  Name = "Potato", Price = 10},
                new ProductVM(){ Id = 11, TypeP="Vegetable",  Name = "Pumpkin", Price = 10},
                new ProductVM(){ Id = 12, TypeP="Drink",  Name = "Juice", Price = 10},
                new ProductVM(){ Id = 13, TypeP="Drink",  Name = "Soda", Price = 10},
                new ProductVM(){ Id = 14, TypeP="Drink",  Name = "Water", Price = 10}
            };
            return products;
        }
    }
}
