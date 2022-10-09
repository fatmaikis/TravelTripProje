using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Sınıflar;

namespace TravelTripProje.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context context = new Context();
        BlogYorum blogyorum = new BlogYorum();
        public ActionResult Index()
        {
            //var bloglar = context.Blogs.ToList();
            blogyorum.Deger1 = context.Blogs.ToList();
            blogyorum.Deger3 = context.Blogs.Take(3).ToList();
            return View(blogyorum);
        }
       

        public ActionResult BlogDetay(int id)
        {

            //var blogbul = context.Blogs.Where(x => x.ID == id).ToList();
            blogyorum.Deger1 = context.Blogs.Where(x => x.ID == id).ToList();
            blogyorum.Deger2 = context.Yorumlars.Where(x => x.Blogid == id).ToList();
            blogyorum.Deger3 = context.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return View(blogyorum);
        }
        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar y)
        {
            context.Yorumlars.Add(y);
            context.SaveChanges();
            return PartialView();

        }
      


        
       
    }
}