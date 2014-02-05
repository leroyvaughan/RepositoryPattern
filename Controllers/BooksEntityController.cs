using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RepositoryPattern.Models.BooksEntity;

namespace RepositoryPattern.Controllers
{ 
    public class BooksEntityController : Controller
    {
        private RantsDBEntities db = new RantsDBEntities();

        //
        // GET: /BooksEntity/

        public ViewResult Index()
        {
            return View(db.BooksTables.ToList());
        }

        //
        // GET: /BooksEntity/Details/5

        public ViewResult Details(Guid id)
        {
            BooksTable bookstable = db.BooksTables.Find(id);
            return View(bookstable);
        }

        //
        // GET: /BooksEntity/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /BooksEntity/Create

        [HttpPost]
        public ActionResult Create(BooksTable bookstable)
        {
            if (ModelState.IsValid)
            {
                bookstable.ID = Guid.NewGuid();
                db.BooksTables.Add(bookstable);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(bookstable);
        }
        
        //
        // GET: /BooksEntity/Edit/5
 
        public ActionResult Edit(Guid id)
        {
            BooksTable bookstable = db.BooksTables.Find(id);
            return View(bookstable);
        }

        //
        // POST: /BooksEntity/Edit/5

        [HttpPost]
        public ActionResult Edit(BooksTable bookstable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bookstable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bookstable);
        }

        //
        // GET: /BooksEntity/Delete/5
 
        public ActionResult Delete(Guid id)
        {
            BooksTable bookstable = db.BooksTables.Find(id);
            return View(bookstable);
        }

        //
        // POST: /BooksEntity/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(Guid id)
        {            
            BooksTable bookstable = db.BooksTables.Find(id);
            db.BooksTables.Remove(bookstable);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}