using Cover2Cover.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cover2Cover.Controllers
{
    public class BooksController : Controller
    {
        private ApplicationDbContext _context;
        public BooksController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Books
        public ActionResult Index()
        {
            var books = _context.Books.Include(b => b.Author).ToList() ;
            return View(books);
        }
        public ActionResult Details(int id)
        {
            var book = _context.Books.Include(a => a.Author).SingleOrDefault(b => b.Id == id);
            if (book !=null)
            {
                return View(book);

            }
            else return HttpNotFound();
            
        }
    }
}