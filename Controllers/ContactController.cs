using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_TripProject.Models;

namespace Travel_TripProject.Controllers
{
    public class ContactController : Controller
    {
        TripDbContext _context= new TripDbContext();
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Delete(int id)
        {
            _context.Contacts.Remove(_context.Contacts.Find(id));
            _context.SaveChanges(); 
            return RedirectToAction("Index");
        }

    }
}