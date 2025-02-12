using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class JobController : Controller
    {
        // GET: Job
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GoToHome()
        {
            return RedirectToAction("Index", "User");
        }

    }
}