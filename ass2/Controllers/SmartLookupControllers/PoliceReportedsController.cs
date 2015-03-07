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
    public class PoliceReportedsController : Controller
    {
        private SimContext db = new SimContext();

        // GET: PoliceReporteds
        public ActionResult Index()
        {
            return View(db.PoliceReported.ToList());
        }

        // GET: PoliceReporteds/Details/5
        [Authorize(Roles = "Administrator")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PoliceReported policeReported = db.PoliceReported.Find(id);
            if (policeReported == null)
            {
                return HttpNotFound();
            }
            return View(policeReported);
        }

        // GET: PoliceReporteds/Create
        [Authorize(Roles = "Administrator")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: PoliceReporteds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public ActionResult Create([Bind(Include = "id,value")] PoliceReported policeReported)
        {
            if (ModelState.IsValid)
            {
                db.PoliceReported.Add(policeReported);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(policeReported);
        }

        // GET: PoliceReporteds/Edit/5
        [Authorize(Roles = "Administrator")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PoliceReported policeReported = db.PoliceReported.Find(id);
            if (policeReported == null)
            {
                return HttpNotFound();
            }
            return View(policeReported);
        }

        // POST: PoliceReporteds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public ActionResult Edit([Bind(Include = "id,value")] PoliceReported policeReported)
        {
            if (ModelState.IsValid)
            {
                db.Entry(policeReported).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(policeReported);
        }

        // GET: PoliceReporteds/Delete/5
        [Authorize(Roles = "Administrator")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PoliceReported policeReported = db.PoliceReported.Find(id);
            if (policeReported == null)
            {
                return HttpNotFound();
            }
            return View(policeReported);
        }

        // POST: PoliceReporteds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public ActionResult DeleteConfirmed(int id)
        {
            PoliceReported policeReported = db.PoliceReported.Find(id);
            db.PoliceReported.Remove(policeReported);
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
