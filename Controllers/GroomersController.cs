using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HydeMvcP1.DAL;
using HydeMvcP1.Models;

namespace HydeMvcP1.Controllers
{
    public class GroomersController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: Groomers
        public ActionResult Index()
        {
            return View(db.Groomers.ToList());
        }

        // GET: Groomers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Groomer groomer = db.Groomers.Find(id);
            if (groomer == null)
            {
                return HttpNotFound();
            }
            return View(groomer);
        }

        // GET: Groomers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Groomers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "groomerID,petOwnerID,description,price")] Groomer groomer)
        {
            if (ModelState.IsValid)
            {
                db.Groomers.Add(groomer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(groomer);
        }

        // GET: Groomers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Groomer groomer = db.Groomers.Find(id);
            if (groomer == null)
            {
                return HttpNotFound();
            }
            return View(groomer);
        }

        // POST: Groomers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "groomerID,petOwnerID,description,price")] Groomer groomer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(groomer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(groomer);
        }

        // GET: Groomers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Groomer groomer = db.Groomers.Find(id);
            if (groomer == null)
            {
                return HttpNotFound();
            }
            return View(groomer);
        }

        // POST: Groomers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Groomer groomer = db.Groomers.Find(id);
            db.Groomers.Remove(groomer);
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
