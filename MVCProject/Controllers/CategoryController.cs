using MVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject.Controllers
{
    public class CategoryController : Controller
    {
        private mvcProjectEntities1 Context;
        public CategoryController()
        {
            Context = new mvcProjectEntities1();            
        }
        
        public ActionResult Index()
        {
            var Cats = Context.Categories;
            return View(Cats);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category cat)
        {
            //logic
            if(cat ==null)
            {
                return HttpNotFound();
            }
            else
            {
                cat.admin_added = 1; //ToDo
                Context.Categories.Add(cat); //added in collection only
                Context.SaveChanges();//added in database
                return RedirectToAction("index");
            }
            
        }
        [HttpGet]
        public ActionResult Delete(int id=0)
        {
            //var catIDeleted = Context.Categories.SingleOrDefault(c => c.id == id);
            var catIDeleted = Context.Categories.Find(id); 
            if(catIDeleted == null)
            {
                return HttpNotFound();
            }
            else
            {
                Context.Categories.Remove(catIDeleted);//collection
                Context.SaveChanges();
                return RedirectToAction("index");
            }
        }


        [HttpGet]
        public ActionResult Edit(int id = 0)
        {
            ViewBag.catIUpdated = Context.Categories.Find(id);
            return View();
        }
        [HttpPost]
        public ActionResult Edit(Category cat)
        {
            //logic
            var oldCat = Context.Categories.Find(cat.id);
            oldCat.id = cat.id;
            oldCat.name = cat.name;
            oldCat.description = cat.description;
            oldCat.admin_added = 1; //ToDo
            Context.SaveChanges();
            return RedirectToAction("index");
        }

    }
}