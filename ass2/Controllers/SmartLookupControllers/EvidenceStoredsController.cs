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

namespace ass2.Controllers.SmartLookupControllers
{
    public class EvidenceStoredsController : Controller
    {
        private SimContext db = new SimContext();

        // GET: EvidenceStoreds
        public ActionResult Index()
        {
            return View(db.EvidenceStored.ToList());
        }

        // GET: EvidenceStoreds/Details/5
        [Authorize(Roles = "Administrator")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EvidenceStored evidenceStored = db.EvidenceStored.Find(id);
            if (evidenceStored == null)
            {
                return HttpNotFound();
            }
            return View(evidenceStored);
        }

        // GET: EvidenceStoreds/Create
        [Authorize(Roles = "Administrator")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: EvidenceStoreds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public ActionResult Create([Bind(Include = "id,value")] EvidenceStored evidenceStored)
        {
            if (ModelState.IsValid)
            {
                db.EvidenceStored.Add(evidenceStored);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(evidenceStored);
        }

        // GET: EvidenceStoreds/Edit/5
        [Authorize(Roles = "Administrator")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EvidenceStored evidenceStored = db.EvidenceStored.Find(id);
            if (evidenceStored == null)
            {
                return HttpNotFound();
            }
            return View(evidenceStored);
        }

        // POST: EvidenceStoreds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public ActionResult Edit([Bind(Include = "id,value")] EvidenceStored evidenceStored)
        {
            if (ModelState.IsValid)
            {
                db.Entry(evidenceStored).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(evidenceStored);
        }

        // GET: EvidenceStoreds/Delete/5
        [Authorize(Roles = "Administrator")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EvidenceStored evidenceStored = db.EvidenceStored.Find(id);
            if (evidenceStored == null)
            {
                return HttpNotFound();
            }
            return View(evidenceStored);
        }

        // POST: EvidenceStoreds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public ActionResult DeleteConfirmed(int id)
        {
            EvidenceStored evidenceStored = db.EvidenceStored.Find(id);
            db.EvidenceStored.Remove(evidenceStored);
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
