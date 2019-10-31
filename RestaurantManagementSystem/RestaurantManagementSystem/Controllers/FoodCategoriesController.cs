﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RestaurantManagementSystem.Models;

namespace RestaurantManagementSystem.Controllers
{
    public class FoodCategoriesController : Controller
    {
        private RestaurantDbContext db = new RestaurantDbContext();

        // GET: FoodCategories
        public ActionResult Index()
        {
            return View(db.FoodCategories.ToList());
        }

        // GET: FoodCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FoodCategory foodCategory = db.FoodCategories.Find(id);
            if (foodCategory == null)
            {
                return HttpNotFound();
            }
            return View(foodCategory);
        }

        // GET: FoodCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FoodCategories/Create
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Description")] FoodCategory foodCategory)
        {
            if (ModelState.IsValid)
            {
                db.FoodCategories.Add(foodCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(foodCategory);
        }

        // GET: FoodCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FoodCategory foodCategory = db.FoodCategories.Find(id);
            if (foodCategory == null)
            {
                return HttpNotFound();
            }
            return View(foodCategory);
        }

        // POST: FoodCategories/Edit/5
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Description")] FoodCategory foodCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(foodCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(foodCategory);
        }

        // GET: FoodCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FoodCategory foodCategory = db.FoodCategories.Find(id);
            if (foodCategory == null)
            {
                return HttpNotFound();
            }
            return View(foodCategory);
        }

        // POST: FoodCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FoodCategory foodCategory = db.FoodCategories.Find(id);
            db.FoodCategories.Remove(foodCategory);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}