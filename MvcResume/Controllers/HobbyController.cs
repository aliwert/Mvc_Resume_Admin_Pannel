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
        public ActionResult Index()
        {
            var hobbies = repo.List();
            return View(hobbies);
        }
    }
}