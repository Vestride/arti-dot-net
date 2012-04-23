using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using arti.Models;
using arti.DAL;

namespace arti.Controllers
{
    public class HomeController : Controller
    {
        private ArtiContext db = new ArtiContext();

        public ActionResult Index()
        {
            ViewBag.Page = "gallery";
            ViewBag.IsProcessing = false;
            var total = db.Artifacts.Count();
            var artifacts = db.Artifacts.OrderBy(a => a.timestamp).ToList();
            ViewBag.total = total;
            return View(artifacts);
        }
    }
}
