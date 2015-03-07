﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MigrationsDemo;
using ass2.Models;

namespace ass2.Controllers
{
    public class CrisesController : Controller
    {
        private SimContext db = new SimContext();

        // GET: Crises
        public ActionResult Index()
        {
            return View(db.Crises.ToList());
        }

        // GET: Crises/Details/5
        [Authorize(Roles = "Administrator")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Crisis crisis = db.Crises.Find(id);
            if (crisis == null)
            {
                return HttpNotFound();
            }
            return View(crisis);
        }

        // GET: Crises/Create
        [Authorize(Roles = "Administrator")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Crises/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public ActionResult Create([Bind(Include = "id,value")] Crisis crisis)
        {
            if (ModelState.IsValid)
            {
                db.Crises.Add(crisis);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(crisis);
        }

        // GET: Crises/Edit/5
        [Authorize(Roles = "Administrator")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Crisis crisis = db.Crises.Find(id);
            if (crisis == null)
            {
                return HttpNotFound();
            }
            return View(crisis);
        }

        // POST: Crises/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public ActionResult Edit([Bind(Include = "id,value")] Crisis crisis)
        {
            if (ModelState.IsValid)
            {
                db.Entry(crisis).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(crisis);
        }

        // GET: Crises/Delete/5
        [Authorize(Roles = "Administrator")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Crisis crisis = db.Crises.Find(id);
            if (crisis == null)
            {
                return HttpNotFound();
            }
            return View(crisis);
        }

        // POST: Crises/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public ActionResult DeleteConfirmed(int id)
        {
            Crisis crisis = db.Crises.Find(id);
            db.Crises.Remove(crisis);
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
