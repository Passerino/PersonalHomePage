using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalHomePage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Gekon, Nie daj się!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
