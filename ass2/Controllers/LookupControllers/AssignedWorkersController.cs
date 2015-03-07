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

namespace ass2.Controllers.LookupControllers
{
    public class AssignedWorkersController : Controller
    {
        private SimContext db = new SimContext();

        // GET: AssignedWorkers
        public ActionResult Index()
        {
            return View(db.AssignedWorkers.ToList());
        }

        // GET: AssignedWorkers/Details/5
        [Authorize(Roles = "Administrator")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AssignedWorker assignedWorker = db.AssignedWorkers.Find(id);
            if (assignedWorker == null)
            {
                return HttpNotFound();
            }
            return View(assignedWorker);
        }

        // GET: AssignedWorkers/Create
        [Authorize(Roles = "Administrator")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: AssignedWorkers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public ActionResult Create([Bind(Include = "id,value")] AssignedWorker assignedWorker)
        {
            if (ModelState.IsValid)
            {
                db.AssignedWorkers.Add(assignedWorker);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(assignedWorker);
        }

        // GET: AssignedWorkers/Edit/5
        [Authorize(Roles = "Administrator")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AssignedWorker assignedWorker = db.AssignedWorkers.Find(id);
            if (assignedWorker == null)
            {
                return HttpNotFound();
            }
            return View(assignedWorker);
        }

        // POST: AssignedWorkers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public ActionResult Edit([Bind(Include = "id,value")] AssignedWorker assignedWorker)
        {
            if (ModelState.IsValid)
            {
                db.Entry(assignedWorker).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(assignedWorker);
        }

        // GET: AssignedWorkers/Delete/5
        [Authorize(Roles = "Administrator")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AssignedWorker assignedWorker = db.AssignedWorkers.Find(id);
            if (assignedWorker == null)
            {
                return HttpNotFound();
            }
            return View(assignedWorker);
        }

        // POST: AssignedWorkers/Delete/5
        [Authorize(Roles = "Administrator")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AssignedWorker assignedWorker = db.AssignedWorkers.Find(id);
            db.AssignedWorkers.Remove(assignedWorker);
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
