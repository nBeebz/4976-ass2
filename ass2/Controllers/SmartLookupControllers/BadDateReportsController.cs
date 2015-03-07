using System;
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
    public class BadDateReportsController : Controller
    {
        private SimContext db = new SimContext();

        // GET: BadDateReports
        public ActionResult Index()
        {
            return View(db.BadDateReport.ToList());
        }

        // GET: BadDateReports/Details/5
        [Authorize(Roles = "Admin")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BadDateReport badDateReport = db.BadDateReport.Find(id);
            if (badDateReport == null)
            {
                return HttpNotFound();
            }
            return View(badDateReport);
        }

        // GET: BadDateReports/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: BadDateReports/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Create([Bind(Include = "id,value")] BadDateReport badDateReport)
        {
            if (ModelState.IsValid)
            {
                db.BadDateReport.Add(badDateReport);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(badDateReport);
        }

        // GET: BadDateReports/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BadDateReport badDateReport = db.BadDateReport.Find(id);
            if (badDateReport == null)
            {
                return HttpNotFound();
            }
            return View(badDateReport);
        }

        // POST: BadDateReports/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit([Bind(Include = "id,value")] BadDateReport badDateReport)
        {
            if (ModelState.IsValid)
            {
                db.Entry(badDateReport).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(badDateReport);
        }

        // GET: BadDateReports/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BadDateReport badDateReport = db.BadDateReport.Find(id);
            if (badDateReport == null)
            {
                return HttpNotFound();
            }
            return View(badDateReport);
        }

        // POST: BadDateReports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteConfirmed(int id)
        {
            BadDateReport badDateReport = db.BadDateReport.Find(id);
            db.BadDateReport.Remove(badDateReport);
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
