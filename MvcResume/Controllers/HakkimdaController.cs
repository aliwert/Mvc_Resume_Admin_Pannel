using MvcResume.Models.Entity;
using MvcResume.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcResume.Controllers
{
    public class HakkimdaController : Controller
    {
        // GET: Hakkimda
        DbCvEntities db = new DbCvEntities();

        GenericRepository<TblAbout> repo = new GenericRepository<TblAbout>();
        [HttpGet]
        public ActionResult Index()
        {
            var about = repo.List();
            return View(about);
        }
        [HttpPost]
        public ActionResult Index(TblAbout p)
        {
            var h = repo.Find(x => x.ID == 1);
            h.Name = p.Name;
            h.Surname = p.Surname;
            h.Adress = p.Adress;
            h.Mail = p.Mail;
            h.Phone = p.Phone;
            h.Description = p.Description;
            h.Fotograf = p.Fotograf;
            repo.TUpdate(h);
            return RedirectToAction("Index");
        }
    }
}