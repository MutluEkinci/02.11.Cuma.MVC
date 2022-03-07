using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UrunController : Controller
    {
        // GET: Urun
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult VeriAl(int id, string ad)
        {
            //Query stringte bulunan değişkenlerle parametreler aynı isimde olmalı.
            return Content("Sayfa Gönderildi..." + id + " " + ad);
        }

        [HttpPost]
        public ActionResult Index(int id, string ad)
        {
            return Content("(Post)Sayfa Gönderildi... " + id + " " + ad);
        }

        public ActionResult IndexIki()
        {
            int id = Convert.ToInt32(Request.Form["id"]);
            string ad = Request.Form["ad"].ToString();

            return Content("Request(Post)Sayfa Gönderildi... " + id + " " + ad);
        }


        [HttpPost]
        public ActionResult IndexUc(FormCollection form)
        {
            int id = Convert.ToInt32(form["id"]);
            string ad = form["ad"].ToString();
            return Content("uc " + id + " " + ad);
        }

        public ActionResult IndexDort()
        {
            return Content("Dort");
        }

        public ActionResult IndexBes(Personel p)
        {
            return Content("Bes"+ p.PerID + " " + p.PerAd);
        }

    }
}