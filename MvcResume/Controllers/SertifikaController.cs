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

        GenericRepository<TblSertifikalarim> repo = new GenericRepository<TblSertifikalarim> ();
        public ActionResult Index()
        {
            var sertifika = repo.List();
            return View(sertifika);
        }
        [HttpGet]
        public ActionResult GetCertificate(int id )
        {
            var sertifika = repo.Find(x=> x.ID == id);
            return View(sertifika);
        }
        [HttpPost]
        public ActionResult GetCertificate(TblSertifikalarim t)
        {
            return View();
        }
    }
}