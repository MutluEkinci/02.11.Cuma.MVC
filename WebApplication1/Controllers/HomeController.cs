using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //Controllerdan view'e veri aktarımı
            //1-ViewData
            //2-ViewBag
            //3-TempData
            //4-Model
            //5-ViewModel

            Personel p = new Personel() { PerID = 111, PerAd = "Kemal Kendir", Maas = 5000 };


            List<Personel> personeller = new List<Personel>
            {
                new Personel() { PerID = 111, PerAd = "Kemal Kendir", Maas = 5000 },
                new Personel() { PerID = 134, PerAd = "Cavit Mavit", Maas = 5500 },
                new Personel() { PerID = 168, PerAd = "Dursun Durmasın", Maas = 6000 }
            };
            ViewData["id"] = 123;
            ViewData["ad"] = "Cevdet";
            ViewData["Personel"] = p;
            ViewData["Personeller"] = personeller;


            ViewBag.No = 124;
            ViewBag.Isim = "Selami";
            ViewBag.Pers = p;
            ViewBag.PerListe = personeller;


            TempData["data"] = "GIZLI VERI";
            TempData.Keep();//Veri geçici olduğu için saklamak gerekir.



            //return View();

            //model ile çalışıyorsak
            return View(p);
        }
        public ActionResult Detay()
        {
            //return Content(TempData["data"].ToString());
            List<Personel> personeller = new List<Personel>
            {
                new Personel() { PerID = 111, PerAd = "Kemal Kendir", Maas = 5000 },
                new Personel() { PerID = 134, PerAd = "Cavit Mavit", Maas = 5500 },
                new Personel() { PerID = 168, PerAd = "Dursun Durmasın", Maas = 6000 }
            };

            return View(personeller);
        }

        public ActionResult ArabaGoster()
        {
            ArabaVM arabaVM = new ArabaVM();

            arabaVM.araba = new Araba() { };
            arabaVM.markalar = new List<Marka> { };
            arabaVM.renkler = new List<Renk> { };
            return View();
        }
    }
}