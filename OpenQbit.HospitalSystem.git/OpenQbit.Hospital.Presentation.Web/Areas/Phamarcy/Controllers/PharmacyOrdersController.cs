using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OpenQbit.Hospital.Common.Models.Phamarcy.OpenQbit.Hospital.Common.Models.Phamarcy;
using OpenQbit.Hospital.DataAccsess.DAL;

namespace OpenQbit.Hospital.Presentation.Web.Areas.Phamarcy.Controllers
{
    public class PharmacyOrdersController : Controller
    {
        private HospitalContext db = new HospitalContext();

        // GET: Phamarcy/PharmacyOrders
        public ActionResult Index()
        {
            var pharmacyOrders = db.PharmacyOrders.Include(p => p.PatientAdmition);
            return View(pharmacyOrders.ToList());
        }

        // GET: Phamarcy/PharmacyOrders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PharmacyOrders pharmacyOrders = db.PharmacyOrders.Find(id);
            if (pharmacyOrders == null)
            {
                return HttpNotFound();
            }
            return View(pharmacyOrders);
        }

        // GET: Phamarcy/PharmacyOrders/Create
        public ActionResult Create()
        {
            ViewBag.PatientAdmitionId = new SelectList(db.PatientAdmition, "ID", "ID");
            return View();
        }

        // POST: Phamarcy/PharmacyOrders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Time,Date,PatientAdmitionId")] PharmacyOrders pharmacyOrders)
        {
            if (ModelState.IsValid)
            {
                db.PharmacyOrders.Add(pharmacyOrders);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PatientAdmitionId = new SelectList(db.PatientAdmition, "ID", "ID", pharmacyOrders.PatientAdmitionId);
            return View(pharmacyOrders);
        }

        // GET: Phamarcy/PharmacyOrders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PharmacyOrders pharmacyOrders = db.PharmacyOrders.Find(id);
            if (pharmacyOrders == null)
            {
                return HttpNotFound();
            }
            ViewBag.PatientAdmitionId = new SelectList(db.PatientAdmition, "ID", "ID", pharmacyOrders.PatientAdmitionId);
            return View(pharmacyOrders);
        }

        // POST: Phamarcy/PharmacyOrders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Time,Date,PatientAdmitionId")] PharmacyOrders pharmacyOrders)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pharmacyOrders).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PatientAdmitionId = new SelectList(db.PatientAdmition, "ID", "ID", pharmacyOrders.PatientAdmitionId);
            return View(pharmacyOrders);
        }

        // GET: Phamarcy/PharmacyOrders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PharmacyOrders pharmacyOrders = db.PharmacyOrders.Find(id);
            if (pharmacyOrders == null)
            {
                return HttpNotFound();
            }
            return View(pharmacyOrders);
        }

        // POST: Phamarcy/PharmacyOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PharmacyOrders pharmacyOrders = db.PharmacyOrders.Find(id);
            db.PharmacyOrders.Remove(pharmacyOrders);
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
