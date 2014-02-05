using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RepositoryPattern.Models;

namespace RepositoryPattern.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            /* this is the original code querying to the data directly */

            //var dataContext = new BooksIReadDataContext();
            //var books = from b in dataContext.BooksIReads 
            //            orderby b.Author 
            //            select b;

            //return View(books);

            return RedirectToAction("Index", "Books");
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
