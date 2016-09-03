using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BartenderRevised.Models;

namespace BartenderRevised.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class StoreManagerController : Controller
    {
        private BartenderRevisedEntities db = new BartenderRevisedEntities();

        //
        // GET: /StoreManager/

        public ViewResult Index()
        {
            var brands = db.Brands.Include(b => b.DrinkType);
            return View(brands.ToList());
        }

        //
        // GET: /StoreManager/Details/5

        public ViewResult Details(int id)
        {
            Brand brand = db.Brands.Find(id);
            return View(brand);
        }

        //
        // GET: /StoreManager/Create

        public ActionResult Create()
        {
            ViewBag.DrinkTypeID = new SelectList(db.DrinkTypes, "DrinkTypeID", "Name");
            return View();
        } 

        //
        // POST: /StoreManager/Create

        [HttpPost]
        public ActionResult Create(Brand brand)
        {
            if (ModelState.IsValid)
            {
                db.Brands.Add(brand);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.DrinkTypeID = new SelectList(db.DrinkTypes, "DrinkTypeID", "Name", brand.DrinkTypeID);
            return View(brand);
        }
        
        //
        // GET: /StoreManager/Edit/5
 
        public ActionResult Edit(int id)
        {
            Brand brand = db.Brands.Find(id);
            ViewBag.DrinkTypeID = new SelectList(db.DrinkTypes, "DrinkTypeID", "Name", brand.DrinkTypeID);
            return View(brand);
        }

        //
        // POST: /StoreManager/Edit/5

        [HttpPost]
        public ActionResult Edit(Brand brand)
        {
            if (ModelState.IsValid)
            {
                db.Entry(brand).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DrinkTypeID = new SelectList(db.DrinkTypes, "DrinkTypeID", "Name", brand.DrinkTypeID);
            return View(brand);
        }

        //
        // GET: /StoreManager/Delete/5
 
        public ActionResult Delete(int id)
        {
            Brand brand = db.Brands.Find(id);
            return View(brand);
        }

        //
        // POST: /StoreManager/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Brand brand = db.Brands.Find(id);
            db.Brands.Remove(brand);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}