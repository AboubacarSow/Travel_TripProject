using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_TripProject.Models;

namespace Travel_TripProject.Controllers
{
    public class AboutController : Controller
    {
        TripDbContext _dbContext = new TripDbContext();
        // GET: About
        public ActionResult Index()
        {
            return View(_dbContext.Abouts.ToList());
        }
        public ActionResult Delete(int id)
        {
            _dbContext.Abouts.Remove(_dbContext.Abouts.Find(id));
            _dbContext.SaveChanges();
            return RedirectToAction("Index");   
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(About about)
        {
            _dbContext.Abouts.Add(about);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");   
        }
        [HttpGet]
        public ActionResult Update(int id)
        {

            return View(_dbContext.Abouts.Find(id));
        }
        [HttpPost]  
        public ActionResult Update(About about)
        {
            var value = _dbContext.Abouts.Find(about.AboutId);
            value.Description = about.Description;  
            value.ImageUrl = about.ImageUrl;
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}