using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TelerikMvcApp1.Models;

namespace TelerikMvcApp1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            var northwind = new SampleEntities();
            // Get the Products entities and add them to the ViewBag.
            ViewBag.Products = northwind.Products;
            return View();
        }
    }
}
