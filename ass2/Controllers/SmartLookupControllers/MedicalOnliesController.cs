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
    public class MedicalOnliesController : Controller
    {
        private SimContext db = new SimContext();

        // GET: MedicalOnlies
        public ActionResult Index()
        {
            return View(db.MedicalOnly.ToList());
        }

        // GET: MedicalOnlies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MedicalOnly medicalOnly = db.MedicalOnly.Find(id);
            if (medicalOnly == null)
            {
                return HttpNotFound();
            }
            return View(medicalOnly);
        }

        // GET: MedicalOnlies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MedicalOnlies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,value")] MedicalOnly medicalOnly)
        {
            if (ModelState.IsValid)
            {
                db.MedicalOnly.Add(medicalOnly);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(medicalOnly);
        }

        // GET: MedicalOnlies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MedicalOnly medicalOnly = db.MedicalOnly.Find(id);
            if (medicalOnly == null)
            {
                return HttpNotFound();
            }
            return View(medicalOnly);
        }

        // POST: MedicalOnlies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,value")] MedicalOnly medicalOnly)
        {
            if (ModelState.IsValid)
            {
                db.Entry(medicalOnly).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(medicalOnly);
        }

        // GET: MedicalOnlies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MedicalOnly medicalOnly = db.MedicalOnly.Find(id);
            if (medicalOnly == null)
            {
                return HttpNotFound();
            }
            return View(medicalOnly);
        }

        // POST: MedicalOnlies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MedicalOnly medicalOnly = db.MedicalOnly.Find(id);
            db.MedicalOnly.Remove(medicalOnly);
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
