using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcResume.Models.Entity;
using MvcResume.Repositories;
namespace MvcResume.Controllers
{
    public class HobbyController : Controller
    {
        // GET: Hobby
        GenericRepository<TblHobilerim> repo = new GenericRepository<TblHobilerim>();
        [HttpGet]
        public ActionResult Index()
        {
            var hobbies = repo.List();
            return View(hobbies);
        }
        [HttpPost]
        public ActionResult Index(TblHobilerim p)
        {
            var h = repo.Find(x => x.ID == 1);
            h.Aciklama1 = p.Aciklama1;
            h.Aciklama2 = p.Aciklama2;
            repo.TUpdate(h);
            return RedirectToAction("Index");
        }
    }
}