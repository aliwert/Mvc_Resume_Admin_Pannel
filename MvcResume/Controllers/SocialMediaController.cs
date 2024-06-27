using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcResume.Models.Entity;
using MvcResume.Repositories;

namespace MvcResume.Controllers
{
    public class SocialMediaController : Controller
    {
        // GET: SocialMedia
        GenericRepository<TblSosyalMedya> repo = new GenericRepository<TblSosyalMedya>();
        public ActionResult Index()
        {
            var veriler = repo.List();
            return View(veriler);
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(TblSosyalMedya p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var hesap = repo.Find(x => x.ID == id);
            return View(hesap);
        }
        [HttpPost]
        public ActionResult Edit(TblSosyalMedya p)
        {
            var hesap = repo.Find(x=> x.ID == p.ID);
            hesap.Name = p.Name;
            hesap.Status = true;
            hesap.Link = p.Link;
            hesap.Icon = p.Icon;
            repo.TUpdate(hesap);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var hesap = repo.Find(x=> x.ID == id);
            hesap.Status = false;
            repo.TUpdate(hesap);
            return RedirectToAction("Index");
        }
    }
}