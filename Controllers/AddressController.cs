using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_TripProject.Models;

namespace Travel_TripProject.Controllers
{
    public class AddressController : Controller
    {
        TripDbContext _dbContext=new TripDbContext();
        // GET: Address
        public ActionResult Index()
        {
            return View(_dbContext.Addresses.ToList());
        }
        public ActionResult Delete(int id)
        {
            _dbContext.Addresses.Remove(_dbContext.Addresses.Find(id));
            _dbContext.SaveChanges();   
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();  
        }
        [HttpPost]
        public ActionResult Create(Address address)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Bir Hata Oluşmuş");
                return View(address);
            }
            _dbContext.Addresses.Add(address);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            return View(_dbContext.Addresses.Find(id));
        }
        [HttpPost]
        public ActionResult Update(Address address)
        {
            var value=_dbContext.Addresses.Find(address.AddressId);
            value.Title=address.Title;  
            value.Description=address.Description;
            value.PhoneNumber=address.PhoneNumber;  
            value.Email=address.Email;  
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}