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
    public class SocialWorkAttendancesController : Controller
    {
        private SimContext db = new SimContext();

        // GET: SocialWorkAttendances
        public ActionResult Index()
        {
            return View(db.SocialWorkAttendance.ToList());
        }

        // GET: SocialWorkAttendances/Details/5
        [Authorize(Roles = "Administrator")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SocialWorkAttendance socialWorkAttendance = db.SocialWorkAttendance.Find(id);
            if (socialWorkAttendance == null)
            {
                return HttpNotFound();
            }
            return View(socialWorkAttendance);
        }

        // GET: SocialWorkAttendances/Create
        [Authorize(Roles = "Administrator")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: SocialWorkAttendances/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public ActionResult Create([Bind(Include = "id,value")] SocialWorkAttendance socialWorkAttendance)
        {
            if (ModelState.IsValid)
            {
                db.SocialWorkAttendance.Add(socialWorkAttendance);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(socialWorkAttendance);
        }

        // GET: SocialWorkAttendances/Edit/5
        [Authorize(Roles = "Administrator")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SocialWorkAttendance socialWorkAttendance = db.SocialWorkAttendance.Find(id);
            if (socialWorkAttendance == null)
            {
                return HttpNotFound();
            }
            return View(socialWorkAttendance);
        }

        // POST: SocialWorkAttendances/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public ActionResult Edit([Bind(Include = "id,value")] SocialWorkAttendance socialWorkAttendance)
        {
            if (ModelState.IsValid)
            {
                db.Entry(socialWorkAttendance).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(socialWorkAttendance);
        }

        // GET: SocialWorkAttendances/Delete/5
        [Authorize(Roles = "Administrator")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SocialWorkAttendance socialWorkAttendance = db.SocialWorkAttendance.Find(id);
            if (socialWorkAttendance == null)
            {
                return HttpNotFound();
            }
            return View(socialWorkAttendance);
        }

        // POST: SocialWorkAttendances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public ActionResult DeleteConfirmed(int id)
        {
            SocialWorkAttendance socialWorkAttendance = db.SocialWorkAttendance.Find(id);
            db.SocialWorkAttendance.Remove(socialWorkAttendance);
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
