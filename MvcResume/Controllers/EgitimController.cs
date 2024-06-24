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
    }
}