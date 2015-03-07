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
    public class RiskLevelsController : Controller
    {
        private SimContext db = new SimContext();

        // GET: RiskLevels
        public ActionResult Index()
        {
            return View(db.RiskLevels.ToList());
        }

        // GET: RiskLevels/Details/5
        [Authorize(Roles = "Administrator")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RiskLevel riskLevel = db.RiskLevels.Find(id);
            if (riskLevel == null)
            {
                return HttpNotFound();
            }
            return View(riskLevel);
        }

        // GET: RiskLevels/Create
        [Authorize(Roles = "Administrator")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: RiskLevels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public ActionResult Create([Bind(Include = "id,value")] RiskLevel riskLevel)
        {
            if (ModelState.IsValid)
            {
                db.RiskLevels.Add(riskLevel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(riskLevel);
        }

        // GET: RiskLevels/Edit/5
        [Authorize(Roles = "Administrator")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RiskLevel riskLevel = db.RiskLevels.Find(id);
            if (riskLevel == null)
            {
                return HttpNotFound();
            }
            return View(riskLevel);
        }

        // POST: RiskLevels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public ActionResult Edit([Bind(Include = "id,value")] RiskLevel riskLevel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(riskLevel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(riskLevel);
        }

        // GET: RiskLevels/Delete/5
        [Authorize(Roles = "Administrator")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RiskLevel riskLevel = db.RiskLevels.Find(id);
            if (riskLevel == null)
            {
                return HttpNotFound();
            }
            return View(riskLevel);
        }

        // POST: RiskLevels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public ActionResult DeleteConfirmed(int id)
        {
            RiskLevel riskLevel = db.RiskLevels.Find(id);
            db.RiskLevels.Remove(riskLevel);
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
