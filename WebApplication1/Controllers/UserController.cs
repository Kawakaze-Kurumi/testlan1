using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GoToJob()
        {
            return RedirectToAction("Index", "Job");
        }

        public ActionResult GoToCustomer()
        {
            return RedirectToAction("Index", "Customer");
        }
    }
}