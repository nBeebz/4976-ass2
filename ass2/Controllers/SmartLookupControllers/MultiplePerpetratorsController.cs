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
    public class MultiplePerpetratorsController : Controller
    {
        private SimContext db = new SimContext();

        // GET: MultiplePerpetrators
        public ActionResult Index()
        {
            return View(db.MultiplePerpetrators.ToList());
        }

        // GET: MultiplePerpetrators/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MultiplePerpetrators multiplePerpetrators = db.MultiplePerpetrators.Find(id);
            if (multiplePerpetrators == null)
            {
                return HttpNotFound();
            }
            return View(multiplePerpetrators);
        }

        // GET: MultiplePerpetrators/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MultiplePerpetrators/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,value")] MultiplePerpetrators multiplePerpetrators)
        {
            if (ModelState.IsValid)
            {
                db.MultiplePerpetrators.Add(multiplePerpetrators);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(multiplePerpetrators);
        }

        // GET: MultiplePerpetrators/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MultiplePerpetrators multiplePerpetrators = db.MultiplePerpetrators.Find(id);
            if (multiplePerpetrators == null)
            {
                return HttpNotFound();
            }
            return View(multiplePerpetrators);
        }

        // POST: MultiplePerpetrators/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,value")] MultiplePerpetrators multiplePerpetrators)
        {
            if (ModelState.IsValid)
            {
                db.Entry(multiplePerpetrators).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(multiplePerpetrators);
        }

        // GET: MultiplePerpetrators/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MultiplePerpetrators multiplePerpetrators = db.MultiplePerpetrators.Find(id);
            if (multiplePerpetrators == null)
            {
                return HttpNotFound();
            }
            return View(multiplePerpetrators);
        }

        // POST: MultiplePerpetrators/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MultiplePerpetrators multiplePerpetrators = db.MultiplePerpetrators.Find(id);
            db.MultiplePerpetrators.Remove(multiplePerpetrators);
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
