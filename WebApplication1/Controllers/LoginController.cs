using System;
using System.Linq;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {
        private Database1Entities db = new Database1Entities();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            var user = db.tbl_TAI_KHOAN.FirstOrDefault(u => u.Username == username && u.Passwords == password);



            if (user != null)
            {
                if (user.Username == "admin")
                {
                    return RedirectToAction("Index", "Admin");
                }
                else
                {
                    return RedirectToAction("Index", "User");
                }
            }

            ViewBag.Message = "Invalid username or password";
            return View("Index");
        }
    }
}
