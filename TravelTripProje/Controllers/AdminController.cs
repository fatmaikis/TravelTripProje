using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Entities;

namespace TravelTripProje.Controllers
{
    public class AdminController : Controller
    {
        Context context = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var value = context.Blogs.ToList();
            return View(value);
        }

        public ActionResult AddBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddBlog(Blog blog)
        {
           context.Blogs.Add(blog);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteBlog(int id)
        {
            var value = context.Blogs.Find(id);
            context.Blogs.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateBlog(int id)
        {
            var value = context.Blogs.Find(id);
            return View(value);

        }
        [HttpPost]
        public ActionResult UpdateBlog(Blog blog)
        {
            var value = context.Blogs.Find(blog.BlogID);
            value.BlogID = blog.BlogID;
            value.Title = blog.Title;   
            value.Date = blog.Date;
            value.Description = blog.Description;   
            value.BlogImage = blog.BlogImage;
            context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}