using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Entities;

namespace TravelTripProje.Controllers
{
    public class CommentController : Controller
    {
        Context context = new Context();
        public ActionResult Index()
        {
            var value = context.Comments.ToList();
            return View(value);
        }

        [HttpGet]
        public ActionResult AddComment()
        {
         
            return View();  
        }
        [HttpPost]
        public ActionResult AddComment(Comment comment)
        {
            context.Comments.Add(comment);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteComment(int id)
        {
            var value = context.Comments.Find(id);
            context.Comments.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateComment(int id)
        {
            var value = context.Comments.Find(id);
            return View(value);

        }
        [HttpPost]
        public ActionResult UpdateComment(Comment comment)
        {
            var value = context.Comments.Find(comment.CommentID);
            value.CommentID = comment.CommentID;
            value.UserName = comment.UserName;
            value.Mail = comment.Mail;
            value.PersonComment = comment.PersonComment;
            
            context.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}