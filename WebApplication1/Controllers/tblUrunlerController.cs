using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Models.DAL;

namespace WebApplication1.Controllers
{
    public class tblUrunlerController : Controller
    {
        Veritabanı veritabanı = new Veritabanı();
        // GET: tblUrunler

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult VeriAl()
        {
            return View();
        }
        [HttpPost]
        public ActionResult VeriAl(tblUrunler u)
        {
            veritabanı.Baglantı(u.UrunAdi, u.KategoriID, u.Fiyat, u.Resim, u.Aciklama);
            return RedirectToAction("Listele");
        }
        public ActionResult Listele()
        {
            return View(veritabanı.TumUrunler());
        }
    }
}