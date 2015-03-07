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
    public class VictimOfIncidentsController : Controller
    {
        private SimContext db = new SimContext();

        // GET: VictimOfIncidents
        public ActionResult Index()
        {
            return View(db.VictimOfIncidents.ToList());
        }

        // GET: VictimOfIncidents/Details/5
        [Authorize(Roles = "Admin")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VictimOfIncident victimOfIncident = db.VictimOfIncidents.Find(id);
            if (victimOfIncident == null)
            {
                return HttpNotFound();
            }
            return View(victimOfIncident);
        }

        // GET: VictimOfIncidents/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: VictimOfIncidents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Create([Bind(Include = "id,value")] VictimOfIncident victimOfIncident)
        {
            if (ModelState.IsValid)
            {
                db.VictimOfIncidents.Add(victimOfIncident);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(victimOfIncident);
        }

        // GET: VictimOfIncidents/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VictimOfIncident victimOfIncident = db.VictimOfIncidents.Find(id);
            if (victimOfIncident == null)
            {
                return HttpNotFound();
            }
            return View(victimOfIncident);
        }

        // POST: VictimOfIncidents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit([Bind(Include = "id,value")] VictimOfIncident victimOfIncident)
        {
            if (ModelState.IsValid)
            {
                db.Entry(victimOfIncident).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(victimOfIncident);
        }

        // GET: VictimOfIncidents/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VictimOfIncident victimOfIncident = db.VictimOfIncidents.Find(id);
            if (victimOfIncident == null)
            {
                return HttpNotFound();
            }
            return View(victimOfIncident);
        }

        // POST: VictimOfIncidents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteConfirmed(int id)
        {
            VictimOfIncident victimOfIncident = db.VictimOfIncidents.Find(id);
            db.VictimOfIncidents.Remove(victimOfIncident);
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
