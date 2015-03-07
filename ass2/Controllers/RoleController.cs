using ass2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ass2.Controllers
{
    public class RoleController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Role
        public ActionResult Index()
        {
            return View(db.Roles.ToList());
        }
    }
}