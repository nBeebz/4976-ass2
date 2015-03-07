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
    public class CityOfResidencesController : Controller
    {
        private SimContext db = new SimContext();

        // GET: CityOfResidences
        public ActionResult Index()
        {
            return View(db.CityOfResidence.ToList());
        }

        // GET: CityOfResidences/Details/5
        [Authorize(Roles = "Administrator")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CityOfResidence cityOfResidence = db.CityOfResidence.Find(id);
            if (cityOfResidence == null)
            {
                return HttpNotFound();
            }
            return View(cityOfResidence);
        }

        // GET: CityOfResidences/Create
        [Authorize(Roles = "Administrator")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: CityOfResidences/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public ActionResult Create([Bind(Include = "id,value")] CityOfResidence cityOfResidence)
        {
            if (ModelState.IsValid)
            {
                db.CityOfResidence.Add(cityOfResidence);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cityOfResidence);
        }

        // GET: CityOfResidences/Edit/5
        [Authorize(Roles = "Administrator")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CityOfResidence cityOfResidence = db.CityOfResidence.Find(id);
            if (cityOfResidence == null)
            {
                return HttpNotFound();
            }
            return View(cityOfResidence);
        }

        // POST: CityOfResidences/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public ActionResult Edit([Bind(Include = "id,value")] CityOfResidence cityOfResidence)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cityOfResidence).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cityOfResidence);
        }

        // GET: CityOfResidences/Delete/5
        [Authorize(Roles = "Administrator")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CityOfResidence cityOfResidence = db.CityOfResidence.Find(id);
            if (cityOfResidence == null)
            {
                return HttpNotFound();
            }
            return View(cityOfResidence);
        }

        // POST: CityOfResidences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public ActionResult DeleteConfirmed(int id)
        {
            CityOfResidence cityOfResidence = db.CityOfResidence.Find(id);
            db.CityOfResidence.Remove(cityOfResidence);
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
