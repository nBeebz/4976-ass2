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
    public class ReferredToCBVSController : Controller
    {
        private SimContext db = new SimContext();

        // GET: ReferredToCBVS
        public ActionResult Index()
        {
            return View(db.ReferredToCBVS.ToList());
        }

        // GET: ReferredToCBVS/Details/5
        [Authorize(Roles = "Admin")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferredToCBVS referredToCBVS = db.ReferredToCBVS.Find(id);
            if (referredToCBVS == null)
            {
                return HttpNotFound();
            }
            return View(referredToCBVS);
        }

        // GET: ReferredToCBVS/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReferredToCBVS/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Create([Bind(Include = "id,value")] ReferredToCBVS referredToCBVS)
        {
            if (ModelState.IsValid)
            {
                db.ReferredToCBVS.Add(referredToCBVS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(referredToCBVS);
        }

        // GET: ReferredToCBVS/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferredToCBVS referredToCBVS = db.ReferredToCBVS.Find(id);
            if (referredToCBVS == null)
            {
                return HttpNotFound();
            }
            return View(referredToCBVS);
        }

        // POST: ReferredToCBVS/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit([Bind(Include = "id,value")] ReferredToCBVS referredToCBVS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(referredToCBVS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(referredToCBVS);
        }

        // GET: ReferredToCBVS/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferredToCBVS referredToCBVS = db.ReferredToCBVS.Find(id);
            if (referredToCBVS == null)
            {
                return HttpNotFound();
            }
            return View(referredToCBVS);
        }

        // POST: ReferredToCBVS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteConfirmed(int id)
        {
            ReferredToCBVS referredToCBVS = db.ReferredToCBVS.Find(id);
            db.ReferredToCBVS.Remove(referredToCBVS);
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
