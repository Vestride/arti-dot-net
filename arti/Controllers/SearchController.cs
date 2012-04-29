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
    public class SearchController : Controller
    {
        private ArtiContext db = new ArtiContext();

        //
        // GET: /Search/

        public ActionResult Index(string username)
        {
            User user = db.Users.FindByUsername(username);
            if (user == null)
            {
                return RedirectToAction("NotFound", new { username = username });
            }
            else
            {
                return RedirectToAction("Index", "User", new { username = username });

            }
        }

        public ActionResult NotFound(string username)
        {
            ViewBag.Username = username;
            return View();
        }

    }
}
