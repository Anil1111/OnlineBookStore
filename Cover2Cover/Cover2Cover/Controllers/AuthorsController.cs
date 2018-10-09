using Cover2Cover.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cover2Cover.Controllers
{
    public class AuthorsController : Controller
    {
        private ApplicationDbContext _context;
        public AuthorsController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Authors
        public ActionResult Index()
        {
            var authors = _context.Authors.Include(b => b.Books).ToList();
            return View(authors);
        }
        public ActionResult Details(int id)
        {
            var author = _context.Authors.SingleOrDefault(a => a.AuthorId == id);
            if (author != null)
            {
                return View(author);

            }
            else return HttpNotFound();
        }
    }
}