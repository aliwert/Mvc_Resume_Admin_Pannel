using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcResume.Models.Entity;
using MvcResume.Repositories;

namespace MvcResume.Controllers
{
    public class ContactController : Controller
    {
        GenericRepository<TblIletisim> repo = new GenericRepository<TblIletisim>();
        public ActionResult Index()
        {
            var message = repo.List();
            return View(message);
        }
    }
}