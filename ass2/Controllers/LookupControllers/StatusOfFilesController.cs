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
    public class StatusOfFilesController : Controller
    {
        private SimContext db = new SimContext();

        // GET: StatusOfFiles
        public ActionResult Index()
        {
            return View(db.StatusOfFiles.ToList());
        }

        // GET: StatusOfFiles/Details/5
        [Authorize(Roles = "Administrator")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StatusOfFile statusOfFile = db.StatusOfFiles.Find(id);
            if (statusOfFile == null)
            {
                return HttpNotFound();
            }
            return View(statusOfFile);
        }

        // GET: StatusOfFiles/Create
        [Authorize(Roles = "Administrator")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: StatusOfFiles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public ActionResult Create([Bind(Include = "id,value")] StatusOfFile statusOfFile)
        {
            if (ModelState.IsValid)
            {
                db.StatusOfFiles.Add(statusOfFile);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(statusOfFile);
        }

        // GET: StatusOfFiles/Edit/5
        [Authorize(Roles = "Administrator")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StatusOfFile statusOfFile = db.StatusOfFiles.Find(id);
            if (statusOfFile == null)
            {
                return HttpNotFound();
            }
            return View(statusOfFile);
        }

        // POST: StatusOfFiles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public ActionResult Edit([Bind(Include = "id,value")] StatusOfFile statusOfFile)
        {
            if (ModelState.IsValid)
            {
                db.Entry(statusOfFile).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(statusOfFile);
        }

        // GET: StatusOfFiles/Delete/5
        [Authorize(Roles = "Administrator")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StatusOfFile statusOfFile = db.StatusOfFiles.Find(id);
            if (statusOfFile == null)
            {
                return HttpNotFound();
            }
            return View(statusOfFile);
        }

        // POST: StatusOfFiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public ActionResult DeleteConfirmed(int id)
        {
            StatusOfFile statusOfFile = db.StatusOfFiles.Find(id);
            db.StatusOfFiles.Remove(statusOfFile);
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
