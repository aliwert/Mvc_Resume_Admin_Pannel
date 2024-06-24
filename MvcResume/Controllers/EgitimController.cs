using MvcResume.Models.Entity;
using MvcResume.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcResume.Controllers
{
    public class EgitimController : Controller
    {
        // GET: Egitim
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

    }
}