using System.Linq;
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

        public ActionResult Delete(int id)
        {
            _dbContext.Blogs.Remove(_dbContext.Blogs.Find(id));
            _dbContext.SaveChanges();
            return RedirectToAction("Index");   
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Blog blog)
        {
            _dbContext.Blogs.Add(blog);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            return View(_dbContext.Blogs.Find(id));
        }
        [HttpPost]  
        public ActionResult Update(Blog blog)
        {
            return View();
        } 
    }
}