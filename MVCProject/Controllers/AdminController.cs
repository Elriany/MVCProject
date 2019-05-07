using MVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject.Controllers
{
    public class AdminController : Controller
    {
        private mvcProjectEntities1 Context;
        public AdminController()
        {
            Context = new mvcProjectEntities1();
        }
        // GET: Admin
        public ActionResult show()
        {
            var adminTbl = Context.Adminstrators;
            return View(adminTbl);
        }
    }
}