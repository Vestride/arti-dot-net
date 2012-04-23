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
    public class ArtifactController : Controller
    {
        private ArtiContext db = new ArtiContext();

        //
        // GET: /Artifact/

        public ViewResult Index()
        {
            var model = db.Artifacts;

            return View(model);
        }

        public ActionResult Details(string id)
        {
            var query = db.Artifacts
                        .Where(a => a.id == id)
                        .Select(a => a);
            Artifact artifact = (Artifact)query.First();
            var req = this.Request;
            ViewBag.permalink = req.Url.ToString();
            ViewBag.title = artifact.owner != "" ? artifact.owner + "&rsquo;s Artifact - " + artifact.id : artifact.id;
            ViewBag.id = artifact.id.Split('_')[1];
            ViewBag.description = "Check out " + artifact.owner + "&rsquo;s artifact: " + artifact.id + " from A.R.T.I.";
            ViewBag.image = req.Url.Host + "/artifacts/" + artifact.id + ".png";

            return View(artifact);
        }
    }
}