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

        [HttpGet]
        public PartialViewResult CreateComment(int id)
        {
            ViewBag.BlogId = id;
            return PartialView(); 
        }

        [HttpPost]
        public ActionResult CreateComment(Comment comment)
        {
            if(!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Hata Oluşmuştur");
                return RedirectToAction("BlogDetails",new { id= comment.BlogId});
            }
            _dbContext.Comments.Add(comment);
            _dbContext.SaveChanges();
            return RedirectToAction("BlogDetails", new { id = comment.BlogId });
        }
        public PartialViewResult LastBlogs()
        {
               
            return PartialView(GetLastBlogs(4));
        }
        public List<Blog> GetLastBlogs(int count)
        {
            return _dbContext.Blogs.OrderByDescending(b => b.CreatedDate).Take(count).ToList();
        }
        public PartialViewResult LastComments(int id)
        {
            var blog=_dbContext.Blogs.Where(b=>b.BlogId == id).FirstOrDefault();
            var comments= blog.Comments.OrderByDescending(c => c.WhenCommented).ToList();
            if (blog.Comments.Count>=5)
            {
                comments=blog.Comments.OrderByDescending(c=>c.WhenCommented).Take(4).ToList();

            }
            return PartialView(comments);
        }

        public PartialViewResult SliderImages()
        {
            return PartialView(_dbContext.Blogs.Select(c => c.ImageUrl).ToList());
        }
        public PartialViewResult LastBlogHome()
        {
            return PartialView(GetLastBlogs(3));
        }
        public PartialViewResult TopTenBlog()
        {
 
            return PartialView(GetTopBlogs(10));
        }
        public PartialViewResult TopSixBlog()
        {
            return PartialView(GetLastBlogs(6));
        }
        private List<Blog> GetTopBlogs(int count)
        {
            var blog = _dbContext.Blogs.OrderByDescending(c => c.Comments.Count).ToList();
            if (blog.Count >= count)
            {
                blog = blog.Take(count).ToList();
            }

            return blog;
        }

    }
}