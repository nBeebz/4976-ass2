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
    public class RepeatClientsController : Controller
    {
        private SimContext db = new SimContext();

        // GET: RepeatClients
        public ActionResult Index()
        {
            return View(db.RepeatClients.ToList());
        }

        // GET: RepeatClients/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RepeatClient repeatClient = db.RepeatClients.Find(id);
            if (repeatClient == null)
            {
                return HttpNotFound();
            }
            return View(repeatClient);
        }

        // GET: RepeatClients/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RepeatClients/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,value")] RepeatClient repeatClient)
        {
            if (ModelState.IsValid)
            {
                db.RepeatClients.Add(repeatClient);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(repeatClient);
        }

        // GET: RepeatClients/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RepeatClient repeatClient = db.RepeatClients.Find(id);
            if (repeatClient == null)
            {
                return HttpNotFound();
            }
            return View(repeatClient);
        }

        // POST: RepeatClients/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,value")] RepeatClient repeatClient)
        {
            if (ModelState.IsValid)
            {
                db.Entry(repeatClient).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(repeatClient);
        }

        // GET: RepeatClients/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RepeatClient repeatClient = db.RepeatClients.Find(id);
            if (repeatClient == null)
            {
                return HttpNotFound();
            }
            return View(repeatClient);
        }

        // POST: RepeatClients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RepeatClient repeatClient = db.RepeatClients.Find(id);
            db.RepeatClients.Remove(repeatClient);
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
