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
    public class UserController : Controller
    {
        private ArtiContext db = new ArtiContext();

        public ViewResult Index(string username)
        {
            User user = db.Users.FindByUsername(username);
            return View(user);
        }
    }
}