using MvcResume.Models.Entity;
using MvcResume.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcResume.Controllers
{
    [Authorize]
    public class EgitimController : Controller
    {
        GenericRepository<TblEgitim> repo = new GenericRepository<TblEgitim>();
        public ActionResult Index()
        {
            var egitim = repo.List();

            return View(egitim);
        }
        [HttpGet]
        public ActionResult AddEducation()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEducation(TblEgitim p)
        {
            if(!ModelState.IsValid)
            {
                return View("AddEducation");
            }
            repo.TAdd(p);

            return RedirectToAction("Index");
        }
        public ActionResult DeleteEducation(int id)
        {
            var egitim = repo.Find(x=> x.ID == id);
            repo.Tdelete(egitim);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditEducation(int id)
        {
            var egitim = repo.Find(x => x.ID == id);
            return View(egitim);
        }
        [HttpPost]
        public ActionResult EditEducation(TblEgitim t)
        {
            if (!ModelState.IsValid)
            {
                return View("EditEducation");
            }
            var egitim = repo.Find(x => x.ID == t.ID);
            egitim.Baslik = t.Baslik;
            egitim.AltBaslik1 = t.AltBaslik1;
            egitim.AltBaslik2 = t.AltBaslik2;
            egitim.Tarih = t.Tarih;
            egitim.GNO = t.GNO;
            repo.TUpdate(egitim);
            return RedirectToAction("Index");
        }

    }
}