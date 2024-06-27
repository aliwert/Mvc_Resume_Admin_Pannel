using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcResume.Models.Entity;

namespace MvcResume.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbCvEntities db = new DbCvEntities();
        public ActionResult Index()
        {
            var degerler = db.TblAbouts.ToList();
            return View(degerler);
        }
        public PartialViewResult SocialMedia()
        {
            var social = db.TblSosyalMedyas.Where(x => x.Status == true).ToList();
            return PartialView(social);
        }
        public PartialViewResult Deneyim()
        {
            var deneyimler = db.TblDeneyimlerims.ToList();
            return PartialView(deneyimler);
        }
        public PartialViewResult Egitim()
        {
            var egitimler = db.TblEgitims.ToList();
            return PartialView(egitimler);
        }
        public PartialViewResult Yetenek()
        {
            var yetenekler = db.TblYeteneklerims.ToList();
            return PartialView(yetenekler);
        }
        public PartialViewResult Hobiler()
        {
            var hobiler = db.TblHobilerims.ToList();
            return PartialView(hobiler);
        }
        public PartialViewResult Certificates()
        {
            var sertifikalar = db.TblSertifikalarims.ToList();
            return PartialView(sertifikalar);
        }

        [HttpGet]
        public PartialViewResult iletisim()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult iletisim(TblIletisim t)
        {
            t.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TblIletisims.Add(t);
            db.SaveChanges();
            return PartialView();
        }
    }
}