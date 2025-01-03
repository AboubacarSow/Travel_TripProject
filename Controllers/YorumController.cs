using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_TripProject.Models;

namespace Travel_TripProject.Controllers
{
    public class YorumController : Controller
    {
        TripDbContext _context=new TripDbContext();
        // GET: Yorum
        public ActionResult Index()
        {
            return View(_context.Comments.ToList());
        }
        public ActionResult SetAsRead(int id)
        {
            var model=_context.Comments.FirstOrDefault(c=>c.CommentId==id);
            model.IsRead = true;
            _context.SaveChanges(); 
            return RedirectToAction("Index");   
        }
        public ActionResult Delete(int id)
        {
            _context.Comments.Remove(_context.Comments.Find(id));
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}