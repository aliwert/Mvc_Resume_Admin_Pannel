using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcResume.Models.Entity;
using MvcResume.Repositories;

namespace MvcResume.Controllers
{
    public class SertifikaController : Controller
    {
        // GET: Sertifika

        GenericRepository<TblSertifikalarim> repo = new GenericRepository<TblSertifikalarim>();
        public ActionResult Index()
        {
            var sertifika = repo.List();
            return View(sertifika);
        }
        [HttpGet]
        public ActionResult GetCertificate(int id)
        {
            var sertifika = repo.Find(x => x.ID == id);
            ViewBag.v = id;
            return View(sertifika);

        }
        [HttpPost]
        public ActionResult GetCertificate(TblSertifikalarim p)
        {
            var sertifika = repo.Find(x => x.ID == p.ID);
            sertifika.Aciklama = p.Aciklama;
            sertifika.Date = p.Date;
            repo.TUpdate(sertifika);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult NewCertificate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewCertificate(TblSertifikalarim p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteCertificate(int id)
        {
            var sertifika = repo.Find(x => x.ID == id);
            repo.Tdelete(sertifika);
            return RedirectToAction("Index");
        }
    }
}