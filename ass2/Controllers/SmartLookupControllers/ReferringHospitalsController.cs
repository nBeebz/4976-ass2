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

namespace ass2.Controllers.LookupControllers
{
    public class ReferringHospitalsController : Controller
    {
        private SimContext db = new SimContext();

        // GET: ReferringHospitals
        public ActionResult Index()
        {
            return View(db.ReferringHospital.ToList());
        }

        // GET: ReferringHospitals/Details/5
        [Authorize(Roles = "Administrator")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferringHospital referringHospital = db.ReferringHospital.Find(id);
            if (referringHospital == null)
            {
                return HttpNotFound();
            }
            return View(referringHospital);
        }

        // GET: ReferringHospitals/Create
        [Authorize(Roles = "Administrator")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReferringHospitals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public ActionResult Create([Bind(Include = "id,value")] ReferringHospital referringHospital)
        {
            if (ModelState.IsValid)
            {
                db.ReferringHospital.Add(referringHospital);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(referringHospital);
        }

        // GET: ReferringHospitals/Edit/5
        [Authorize(Roles = "Administrator")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferringHospital referringHospital = db.ReferringHospital.Find(id);
            if (referringHospital == null)
            {
                return HttpNotFound();
            }
            return View(referringHospital);
        }

        // POST: ReferringHospitals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public ActionResult Edit([Bind(Include = "id,value")] ReferringHospital referringHospital)
        {
            if (ModelState.IsValid)
            {
                db.Entry(referringHospital).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(referringHospital);
        }

        // GET: ReferringHospitals/Delete/5
        [Authorize(Roles = "Administrator")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferringHospital referringHospital = db.ReferringHospital.Find(id);
            if (referringHospital == null)
            {
                return HttpNotFound();
            }
            return View(referringHospital);
        }

        // POST: ReferringHospitals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public ActionResult DeleteConfirmed(int id)
        {
            ReferringHospital referringHospital = db.ReferringHospital.Find(id);
            db.ReferringHospital.Remove(referringHospital);
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
