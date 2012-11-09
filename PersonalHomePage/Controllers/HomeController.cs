using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalHomePage.Controllers
{
    public partial class HomeController : Controller
    {
        public virtual ActionResult Index()
        {
            ViewBag.Message = "Gekon, Nie daj się!";

            return View();
        }

        public virtual ActionResult About()
        {
            return View();
        }
    }
}
