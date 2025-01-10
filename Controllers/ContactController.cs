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
            return View(_context.Contacts.ToList());
        }
        public ActionResult Delete(int id)
        {
            _context.Contacts.Remove(_context.Contacts.Find(id));
            _context.SaveChanges(); 
            return RedirectToAction("Index");
        }
        public ActionResult SetAsRead(int id)
        {
            var value=_context.Contacts.Find(id);
            value.IsRead = true;    
            return RedirectToAction("Index");
        }

    }
}