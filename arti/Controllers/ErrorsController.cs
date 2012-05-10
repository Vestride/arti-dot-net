using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace arti.Controllers
{
    public class ErrorsController : Controller
    {
        //
        // GET: /Errors/

        public ActionResult General(Exception exception)
        {
            return RedirectToAction("Message", "Home", new { message = "General Failure. Whoops!" });
        }

        public ActionResult Http404()
        {
            ViewBag.title = "Oops! Nothing here!";
            return View();
        }

        public ActionResult Http403()
        {
            return RedirectToAction("Message", "Home", new { message = "Sorry, you are not allowed to see that 0_o" });
        }

    }
}
