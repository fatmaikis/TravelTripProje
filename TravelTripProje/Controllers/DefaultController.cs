using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Entities;

namespace TravelTripProje.Controllers
{
    public class DefaultController : Controller
    {
        Context context = new Context();
        public ActionResult Index()
        {
            var value = context.Blogs.Take(10).ToList();
            return View(value);
        }

        public PartialViewResult PartialTopTen()
        {
            var value = context.Blogs.Take(10).ToList();
            return PartialView(value);
        }

        public PartialViewResult PartialOurBestPlace()
        {
            var value = context.Blogs.Take(3).ToList();
            return PartialView(value);
        }
        public PartialViewResult PartialOurBestPlace2()
        {
            var value = context.Blogs.Take(3).OrderByDescending(x=>x.BlogID).ToList();
            return PartialView(value);
        }

    }
}