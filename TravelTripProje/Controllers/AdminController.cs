using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Sınıflar;


namespace TravelTripProje.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context context = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = context.Blogs.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniBlog(Blog p)
        {
            context.Blogs.Add(p);
            context.SaveChanges();  
            return RedirectToAction("Index");
        }
        public ActionResult BlogSil(int id)
        {
            var blog=context.Blogs.Find(id);
            context.Blogs.Remove(blog); 
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogGetir(int id)
        {
            var blog = context.Blogs.Find(id);
            return View("BlogGetir",blog);
        }
        public ActionResult BlogGuncelle(Blog b)
        {
            var blog = context.Blogs.Find(b.ID);
            blog.Aciklama = b.Aciklama;
            blog.Baslik = b.Baslik;
            blog.BlogImage = b.BlogImage;
            blog.Tarih = b.Tarih;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult YorumListesi()
        {
            var yorumlar = context.Yorumlars.ToList();
            return View(yorumlar);  
        }
        public ActionResult YorumSil(int id)
        {
            var y = context.Yorumlars.Find(id);
            context.Yorumlars.Remove(y);
            context.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        public ActionResult YorumGetir(int id)
        {
            var yorum = context.Yorumlars.Find(id);
            return View("YorumGetir",yorum);
        }
        public ActionResult YorumGuncelle(Yorumlar y)
        {
            var yrm = context.Yorumlars.Find(y.ID);
            yrm.KullaniciAdi = y.KullaniciAdi;
            yrm.Mail = y.Mail;
            yrm.Yorum = y.Yorum;
            //yrm.Blogid = y.Blogid;
            yrm.Blog = y.Blog;
            context.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
    }
}