using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace arti.Controllers
{
    public class TeamController : Controller
    {
        //
        // GET: /Team/

        public ActionResult Index()
        {
            ViewBag.title = "Team Members";
            ViewBag.Page = "team";
            ViewBag.description = "Meet the team behind A.R.T.I.";
            return View();
        }

    }
}
