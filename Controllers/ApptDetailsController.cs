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
    public class ApptDetailsController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: ApptDetails
        public ActionResult Index()
        {
            var apptDetails = db.ApptDetails.Include(a => a.Appointment).Include(a => a.Pet);
            return View(apptDetails.ToList());
        }

        // GET: ApptDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApptDetail apptDetail = db.ApptDetails.Find(id);
            if (apptDetail == null)
            {
                return HttpNotFound();
            }
            return View(apptDetail);
        }

        // GET: ApptDetails/Create
        public ActionResult Create()
        {
            ViewBag.appointmentID = new SelectList(db.Appointment, "appointmentID", "description");
            ViewBag.petID = new SelectList(db.Pet, "petID", "description");
            return View();
        }

        // POST: ApptDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "apptDetailID,qtyOrdered,price,appointmentID,petID")] ApptDetail apptDetail)
        {
            if (ModelState.IsValid)
            {
                db.ApptDetails.Add(apptDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.appointmentID = new SelectList(db.Appointment, "appointmentID", "description", apptDetail.appointmentID);
            ViewBag.petID = new SelectList(db.Pet, "petID", "description", apptDetail.petID);
            return View(apptDetail);
        }

        // GET: ApptDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApptDetail apptDetail = db.ApptDetails.Find(id);
            if (apptDetail == null)
            {
                return HttpNotFound();
            }
            ViewBag.appointmentID = new SelectList(db.Appointment, "appointmentID", "description", apptDetail.appointmentID);
            ViewBag.petID = new SelectList(db.Pet, "petID", "description", apptDetail.petID);
            return View(apptDetail);
        }

        // POST: ApptDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "apptDetailID,qtyOrdered,price,appointmentID,petID")] ApptDetail apptDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(apptDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.appointmentID = new SelectList(db.Appointment, "appointmentID", "description", apptDetail.appointmentID);
            ViewBag.petID = new SelectList(db.Pet, "petID", "description", apptDetail.petID);
            return View(apptDetail);
        }

        // GET: ApptDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApptDetail apptDetail = db.ApptDetails.Find(id);
            if (apptDetail == null)
            {
                return HttpNotFound();
            }
            return View(apptDetail);
        }

        // POST: ApptDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ApptDetail apptDetail = db.ApptDetails.Find(id);
            db.ApptDetails.Remove(apptDetail);
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
