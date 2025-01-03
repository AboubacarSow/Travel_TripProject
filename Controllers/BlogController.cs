using System;
using System.IO;
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
            if (ModelState.IsValid)
            {
                if (blog.ImageFile != null)
                {
                    var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    var saveLocation = currentDirectory + "Assets//";
                    var fileName = Path.Combine(saveLocation, blog.ImageFile.FileName);
                    blog.ImageFile.SaveAs(fileName);
                    blog.ImageUrl = "/Assets/" + blog.ImageFile.FileName;
                }
                    _dbContext.Blogs.Add(blog);
                    _dbContext.SaveChanges();
                    return RedirectToAction("Index");
            }
            return View(blog);

        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            return View(_dbContext.Blogs.Find(id));
        }
        [HttpPost]  
        public ActionResult Update(Blog blog)
        {
            if (!ModelState.IsValid)
            {
                var model = _dbContext.Blogs.FirstOrDefault(b => b.BlogId == blog.BlogId);
                if (!(blog.ImageFile == null))
                {
                    var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    var saveLocation = currentDirectory + "Assetes//";
                    var fileName = Path.Combine(saveLocation, blog.ImageFile.FileName);
                    blog.ImageFile.SaveAs(fileName);
                    blog.ImageUrl = "/Assets/" + blog.ImageFile.FileName;
                    model.ImageUrl=blog.ImageUrl;
                }
                model.Title= blog.Title; 
                model.Description=blog.Description; 
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(blog);
        } 
    }
}