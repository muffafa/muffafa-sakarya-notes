using H3WebYaz.Models;
using Microsoft.AspNetCore.Mvc;

namespace H3WebYaz.Controllers
{
    public class OgrenciController : Controller
    {
      static  List<Ogrenci> ogrenciler =new List<Ogrenci>();
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string OgrKaydet()
        {
            string durum = HttpContext.Request.Query["durum"];
            string ad = HttpContext.Request.Form["OgrAd"];
            string soyad = HttpContext.Request.Form["OgrSoyad"];
            string no = HttpContext.Request.Form["OgrNo"];
            string txt = ad + " " + soyad + " " + no;
            return txt;
        }
        [HttpGet]
        public string OgrKaydetGet()
        {
            string ad = HttpContext.Request.Query["OgrAd"];
            string soyad = HttpContext.Request.Query["OgrSoyad"];
            string no = HttpContext.Request.Query["OgrNo"];

            string txt = ad + " " + soyad + " " + no;
            return txt;
        }

        public string OgrKaydetBagla(string OgrAd,string OgrSoyad, string OgrNo)
        {
         
            string txt = OgrAd + " " + OgrSoyad + " " + OgrNo;
            return txt;
        }

        public IActionResult OgrKaydetSinif(Ogrenci ogr)
        {

            string txt = ogr.OgrAd + " " + ogr.OgrSoyad + " " + ogr.OgrNo;
            return View(ogr);
        }

        public IActionResult OgrKaydetSon(Ogrenci ogr)
        {
           // kontrol(ogr);
            ogrenciler.Add(ogr);
            string txt = ogr.OgrAd + " " + ogr.OgrSoyad + " " + ogr.OgrNo;
            return View(ogrenciler);
        }
    }
}
