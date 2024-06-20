using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Entities;

namespace TravelTripProje.Controllers
{
    public class AboutController : Controller
    {
        Context context = new Context();
        public ActionResult Index()
        {
            var value = context.Abouts.ToList();
            return View(value);
        }
    }
}