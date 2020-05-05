using MVC_Ajax_Post_Form.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Ajax_Post_Form.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        [HttpPost]
        public ActionResult Index(Comment comment)
        {
            Comment ajaxComment = new Comment();
           
            ajaxComment.CommentText = comment.CommentText;
            ajaxComment.DateCreated = comment.DateCreated;
            ajaxComment.PostId = comment.PostId;
            ajaxComment.UserName = comment.UserName;

            //mRep.Add(ajaxComment);
            //uow.Save();
            //Get all the comments for the given post id

            return Json(ajaxComment);
            //return View(); For non-AJAX postback


        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}
