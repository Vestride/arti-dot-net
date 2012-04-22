using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace arti.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Page = "gallery";
            ViewBag.IsProcessing = false;
            ViewBag.total = 12;
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
