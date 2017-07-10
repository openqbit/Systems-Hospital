using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OpenQbit.Hospital.Common.Models.OpenQbit.Hospital.Common.Models;
using OpenQbit.Hospital.DataAccsess.DAL;

namespace OpenQbit.Hospital.Presentation.Web.Controllers
{
    public class PatientAdmitionsController : Controller
    {
        private HospitalContext db = new HospitalContext();

        // GET: PatientAdmitions
        public ActionResult Index()
        {
            var patientAdmition = db.PatientAdmition.Include(p => p.Patient);
            return View(patientAdmition.ToList());
        }

        // GET: PatientAdmitions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PatientAdmition patientAdmition = db.PatientAdmition.Find(id);
            if (patientAdmition == null)
            {
                return HttpNotFound();
            }
            return View(patientAdmition);
        }

        // GET: PatientAdmitions/Create
        public ActionResult Create()
        {
            ViewBag.PatientId = new SelectList(db.Patient, "ID", "PatientName");
            return View();
        }

        // POST: PatientAdmitions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,PatientId,Date")] PatientAdmition patientAdmition)
        {
            if (ModelState.IsValid)
            {
                db.PatientAdmition.Add(patientAdmition);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PatientId = new SelectList(db.Patient, "ID", "PatientName", patientAdmition.PatientId);
            return View(patientAdmition);
        }

        // GET: PatientAdmitions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PatientAdmition patientAdmition = db.PatientAdmition.Find(id);
            if (patientAdmition == null)
            {
                return HttpNotFound();
            }
            ViewBag.PatientId = new SelectList(db.Patient, "ID", "PatientName", patientAdmition.PatientId);
            return View(patientAdmition);
        }

        // POST: PatientAdmitions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,PatientId,Date")] PatientAdmition patientAdmition)
        {
            if (ModelState.IsValid)
            {
                db.Entry(patientAdmition).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PatientId = new SelectList(db.Patient, "ID", "PatientName", patientAdmition.PatientId);
            return View(patientAdmition);
        }

        // GET: PatientAdmitions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PatientAdmition patientAdmition = db.PatientAdmition.Find(id);
            if (patientAdmition == null)
            {
                return HttpNotFound();
            }
            return View(patientAdmition);
        }

        // POST: PatientAdmitions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PatientAdmition patientAdmition = db.PatientAdmition.Find(id);
            db.PatientAdmition.Remove(patientAdmition);
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
