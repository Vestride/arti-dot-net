using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace arti.Controllers
{
    public class IdeaController : Controller
    {
        //
        // GET: /Idea/

        public ActionResult Index()
        {
            ViewBag.title = "The Idea";
            ViewBag.Page = "idea";
            ViewBag.description = "An overview and explaintion of A.R.T.I. and the process we went through to build it.";
            ViewBag.videojs = true;
            return View();
        }

    }
}
