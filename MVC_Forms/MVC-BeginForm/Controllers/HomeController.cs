using MVC_BeginForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_BeginForm.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult FriendDetail()
        {

            return View();
        }

        [HttpPost]
        public ActionResult FriendDetail(tblFriend _friend)
        {
            MBKTestContext db = new MBKTestContext();
            db.Friends.Add(_friend);
            db.SaveChanges();
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


    }
}