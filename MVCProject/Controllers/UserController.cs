using MVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject.Controllers
{
    public class UserController : Controller
    {
        private mvcProjectEntities1 context;
        public UserController()
        {
            context = new mvcProjectEntities1();
        }
        public ActionResult Index()
        {
            var users = context.userTbls;
            return View(users);
        }   
    }
}