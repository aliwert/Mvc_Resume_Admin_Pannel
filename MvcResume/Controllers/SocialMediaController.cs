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
    }
}