using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OpenQbit.Hospital.Common.Models.Ward;
using OpenQbit.Hospital.DataAccsess.DAL;

namespace OpenQbit.Hospital.Presentation.Web.Controllers
{
    public class WardsController : Controller
    {
        private PharmacyContext db = new PharmacyContext();

        // GET: Wards
        public ActionResult Index()
        {
            var wards = db.Wards.Include(w => w.Incharge).Include(w => w.WardType);
            return View(wards.ToList());
        }

        // GET: Wards/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ward ward = db.Wards.Find(id);
            if (ward == null)
            {
                return HttpNotFound();
            }
            return View(ward);
        }

        // GET: Wards/Create
        public ActionResult Create()
        {
            ViewBag.InchargeID = new SelectList(db.Employees, "EmployeeId", "EmployeeId");
            ViewBag.WardTypeId = new SelectList(db.WardTypes, "WardTypeId", "Name");
            return View();
        }

        // POST: Wards/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Type,Description,InchargeID,WardTypeId")] Ward ward)
        {
            if (ModelState.IsValid)
            {
                db.Wards.Add(ward);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.InchargeID = new SelectList(db.Employees, "EmployeeId", "EmployeeId", ward.InchargeID);
            ViewBag.WardTypeId = new SelectList(db.WardTypes, "WardTypeId", "Name", ward.WardTypeId);
            return View(ward);
        }

        // GET: Wards/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ward ward = db.Wards.Find(id);
            if (ward == null)
            {
                return HttpNotFound();
            }
            ViewBag.InchargeID = new SelectList(db.Employees, "EmployeeId", "EmployeeId", ward.InchargeID);
            ViewBag.WardTypeId = new SelectList(db.WardTypes, "WardTypeId", "Name", ward.WardTypeId);
            return View(ward);
        }

        // POST: Wards/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Type,Description,InchargeID,WardTypeId")] Ward ward)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ward).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.InchargeID = new SelectList(db.Employees, "EmployeeId", "EmployeeId", ward.InchargeID);
            ViewBag.WardTypeId = new SelectList(db.WardTypes, "WardTypeId", "Name", ward.WardTypeId);
            return View(ward);
        }

        // GET: Wards/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ward ward = db.Wards.Find(id);
            if (ward == null)
            {
                return HttpNotFound();
            }
            return View(ward);
        }

        // POST: Wards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ward ward = db.Wards.Find(id);
            db.Wards.Remove(ward);
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
