using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_TripProject.Models;

namespace Travel_TripProject.Controllers
{
    public class BlogController : Controller
    {
        TripDbContext _dbContext = new TripDbContext();
        // GET: Blog
        public ActionResult Index()
        {
            return View(_dbContext.Blogs.ToList());
        }
    }
}