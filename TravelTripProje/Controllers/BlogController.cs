using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Entities;

namespace TravelTripProje.Controllers
{
    public class BlogController : Controller
    {
        Context context = new Context();
		BlogComment bc = new BlogComment();
		public ActionResult Index()
        {
            //var value = context.Blogs.ToList();
            bc.Value1=context.Blogs.ToList();
            bc.Value3 = context.Blogs.OrderByDescending(x=>x.BlogID).Take(3).ToList(); 
            return View(bc);
        }
		
		public ActionResult BlogDetail(int id)
        {
            //var findblog = context.Blogs.Where(x => x.BlogID == id).ToList() ;
            bc.Value1 = context.Blogs.Where(x => x.BlogID == id).ToList();
            bc.Value2 = context.Comments.Where(x => x.BlogID == id).ToList();
            return View(bc); 
        }
        [HttpGet]
        public PartialViewResult DoComment(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult DoComment(Comment comment)
        {
            context.Comments.Add(comment);
            context.SaveChanges();
            return PartialView();
        }
     

      
    }
}