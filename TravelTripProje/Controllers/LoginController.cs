using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelTripProje.Models.Entities;

namespace TravelTripProje.Controllers
{
    
    public class LoginController : Controller
    {
        Context context = new Context();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin admin )
        {
            var info = context.Admins.FirstOrDefault(x=>x.UserName==admin.UserName && x.Password==admin.Password );
            if (info !=null)
            {
                FormsAuthentication.SetAuthCookie(info.UserName, false);
                Session["Kullanici"] = info.UserName.ToString();
                return RedirectToAction("Index","Admin");
            }
            else
            {
                return View();
            }
            
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login","Login");
        }
    }
}