using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using arti.Models;
using arti.DAL;
using arti.Queries;

namespace arti.Controllers
{
    public class TeamController : Controller
    {
        private ArtiContext db = new ArtiContext();

        //
        // GET: /Team/

        public ActionResult Index()
        {
            ViewBag.title = "Team Members";
            ViewBag.Page = "team";
            ViewBag.description = "Meet the team behind A.R.T.I.";
            var team = db.TeamMembers.GetRandom();
            return View(team);
        }

    }
}
