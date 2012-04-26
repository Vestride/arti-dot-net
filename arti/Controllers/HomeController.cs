using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using arti.Models;
using arti.DAL;
using arti.Queries;

namespace arti.Controllers
{
    public class HomeController : Controller
    {
        private ArtiContext db = new ArtiContext();

        public ActionResult Index()
        {
            ViewBag.Page = "gallery";
            ViewBag.IsProcessing = false;
            ViewBag.total = db.Artifacts.Count();
            var artifacts = db.Artifacts.GetRecent();
            return View(artifacts);
        }

        
        public PartialViewResult Popular(int start, int stop)
        {
            var total = db.Artifacts.Count();
            var artifacts = db.Artifacts.GetPopular(start, stop);
            ViewBag.totalArtifacts = total;
            return PartialView("artifact-grid", artifacts);
        }

        public PartialViewResult Recent(int start, int stop)
        {
            ViewBag.totalArtifacts = db.Artifacts.Count();
            var artifacts = db.Artifacts.GetRecent(start, stop);
            return PartialView("artifact-grid", artifacts);
        }

        public PartialViewResult Featured(int start, int stop)
        {
            ViewBag.totalArtifacts = db.Artifacts.Count();
            var artifacts = db.Artifacts.GetFeatured(start, stop);
            return PartialView("artifact-grid", artifacts);
        }

        public PartialViewResult Favorites(int start, int stop)
        {
            ViewBag.totalArtifacts = db.Artifacts.Count();
            var artifacts = db.Artifacts.GetFavorites(start, stop);
            return PartialView("artifact-grid", artifacts);
        }

        public bool Views(string id)
        {
            db.Artifacts.FindById(id).views += 1;
            return db.SaveChanges() > 0;
        }

        public bool Stars(string id)
        {
            db.Artifacts.FindById(id).stars += 1;
            return db.SaveChanges() > 0;
        }
    }
}
