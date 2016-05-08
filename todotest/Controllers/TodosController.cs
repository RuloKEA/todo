using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using todotest.DAL;
using todotest.Models;

namespace todotest.Controllers
{
    public class TodosController : Controller
    {
        private TodoContext db = new TodoContext();
        // GET: Todos 
        public ActionResult Index(bool? done)
        {
            ViewBag.Current = null;
            List<Todo> todos = db.Todos.ToList();
            if(done != null)
            {
               ViewBag.Current = done;
               todos = todos.Where(i => i.Done == done).ToList();
            }
            return View(todos);
        }

        public ActionResult Details(int id)
        {
            Todo todo = db.Todos.Find(id); 
            return View(todo);
        }

        public ActionResult Create()
        {
            ViewBag.Create = true;
            return View();
        }
        [HttpPost]
        public ActionResult Create(Todo todo)
        {
            this.db.Todos.Add(todo);
            this.db.SaveChanges();
            return RedirectToAction("index");
        }

        public ActionResult Done(int id)
        {
            Todo todo = db.Todos.Find(id);
            todo.Done = !todo.Done;
            db.SaveChanges();
            return RedirectToAction("index");
        }
    }
}