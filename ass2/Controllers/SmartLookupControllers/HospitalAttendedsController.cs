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
    public class HospitalAttendedsController : Controller
    {
        private SimContext db = new SimContext();

        // GET: HospitalAttendeds
        public ActionResult Index()
        {
            return View(db.HospitalAttended.ToList());
        }

        // GET: HospitalAttendeds/Details/5
        [Authorize(Roles = "Administrator")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HospitalAttended hospitalAttended = db.HospitalAttended.Find(id);
            if (hospitalAttended == null)
            {
                return HttpNotFound();
            }
            return View(hospitalAttended);
        }

        // GET: HospitalAttendeds/Create
        [Authorize(Roles = "Administrator")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: HospitalAttendeds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public ActionResult Create([Bind(Include = "id,value")] HospitalAttended hospitalAttended)
        {
            if (ModelState.IsValid)
            {
                db.HospitalAttended.Add(hospitalAttended);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hospitalAttended);
        }

        // GET: HospitalAttendeds/Edit/5
        [Authorize(Roles = "Administrator")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HospitalAttended hospitalAttended = db.HospitalAttended.Find(id);
            if (hospitalAttended == null)
            {
                return HttpNotFound();
            }
            return View(hospitalAttended);
        }

        // POST: HospitalAttendeds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public ActionResult Edit([Bind(Include = "id,value")] HospitalAttended hospitalAttended)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hospitalAttended).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hospitalAttended);
        }

        // GET: HospitalAttendeds/Delete/5
        [Authorize(Roles = "Administrator")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HospitalAttended hospitalAttended = db.HospitalAttended.Find(id);
            if (hospitalAttended == null)
            {
                return HttpNotFound();
            }
            return View(hospitalAttended);
        }

        // POST: HospitalAttendeds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public ActionResult DeleteConfirmed(int id)
        {
            HospitalAttended hospitalAttended = db.HospitalAttended.Find(id);
            db.HospitalAttended.Remove(hospitalAttended);
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
