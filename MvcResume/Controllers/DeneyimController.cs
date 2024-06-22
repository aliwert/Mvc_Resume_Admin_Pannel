using MvcResume.Models.Entity;
using MvcResume.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcResume.Controllers
{
    public class DeneyimController : Controller
    {
        // GET: Deneyim
        DeneyimRepository dp = new DeneyimRepository();
        public ActionResult Index()
        {
            var deneyimler = dp.List();
            return View(deneyimler);
        }
        [HttpGet]
        public ActionResult AddExperience()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddExperience(TblDeneyimlerim p)
        {
            dp.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteExperience(int id)
        {
            TblDeneyimlerim t = dp.Find(x=> x.ID == id);
            dp.Tdelete(t);
            return RedirectToAction("Index");
        }
    }
}