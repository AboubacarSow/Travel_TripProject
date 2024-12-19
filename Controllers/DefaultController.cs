using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_TripProject.Models;

namespace Travel_TripProject.Controllers
{
    public class DefaultController : Controller
    {
        TripDbContext _dbContext = new TripDbContext();
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View(_dbContext.Abouts.ToList());
        }
        public ActionResult BlogList()
        {
            return View(_dbContext.Blogs.ToList());
        }
        public ActionResult BlogDetails(int id)
        {
            return View(_dbContext.Blogs.Find(id));
        }
    }
}