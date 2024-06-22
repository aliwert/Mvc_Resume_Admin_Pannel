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
    }
}