using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Carpe_Librum_Proto_0.Models;

namespace Carpe_Librum_Proto_0.Controllers
{
    public class BookSugestionSetController : Controller
    {
        private BookSugestionDbContext context = new BookSugestionDbContext();

        // GET: BookSugestionSet
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListOfBooks()
        {
            //Read all entries from table then store them in list
            List<BookSugestion> booksinlist = context.BookSugestionSet.ToList();
            //Send them to view
            return View(booksinlist);
        }

        
        [HttpGet]
        public ActionResult CreateBook()
        {

            return View();
        }



        [HttpPost]
        public ActionResult CreateBooK(BookSugestion book)
        {
            if (ModelState.IsValid)
            {
                //Time fo sugestion creation
                book.GetDateTime = DateTime.Now;
                // will add the book sugestion to the table in the Database
                context.BookSugestionSet.Add(book);
                // Save the changes to DB 
                context.SaveChanges();

                return View("Details", book);
            }

            return View(book);
        }
        

        public ActionResult Details(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }

            BookSugestion book = context.BookSugestionSet.Find(id);

            return View(book);
        }

   


       
        public ActionResult BookOfMonth(int? id=3)
        {
           
            BookSugestion book = context.BookSugestionSet.Find(id);

            return View(book); ;

        }






    }
}