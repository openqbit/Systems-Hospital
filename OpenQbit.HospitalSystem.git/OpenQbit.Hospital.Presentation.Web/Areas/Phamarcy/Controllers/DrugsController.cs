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
    public class DrugsController : Controller
    {
        private PharmacyContext db = new PharmacyContext();

        // GET: Phamarcy/Drugs
        public ActionResult Index()
        {
            var drug = db.Drug.Include(d => d.Category).Include(d => d.Medicine);
            return View(drug.ToList());
        }

        // GET: Phamarcy/Drugs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Drug drug = db.Drug.Find(id);
            if (drug == null)
            {
                return HttpNotFound();
            }
            return View(drug);
        }

        // GET: Phamarcy/Drugs/Create
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(db.Category, "ID", "CategoryName");
            ViewBag.MedicineId = new SelectList(db.Medicine, "ID", "ID");
            return View();
        }

        // POST: Phamarcy/Drugs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,drugName,Description,Company,MedicineId,CategoryId")] Drug drug)
        {
            if (ModelState.IsValid)
            {
                db.Drug.Add(drug);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoryId = new SelectList(db.Category, "ID", "CategoryName", drug.CategoryId);
            ViewBag.MedicineId = new SelectList(db.Medicine, "ID", "ID", drug.MedicineId);
            return View(drug);
        }

        // GET: Phamarcy/Drugs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Drug drug = db.Drug.Find(id);
            if (drug == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryId = new SelectList(db.Category, "ID", "CategoryName", drug.CategoryId);
            ViewBag.MedicineId = new SelectList(db.Medicine, "ID", "ID", drug.MedicineId);
            return View(drug);
        }

        // POST: Phamarcy/Drugs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,drugName,Description,Company,MedicineId,CategoryId")] Drug drug)
        {
            if (ModelState.IsValid)
            {
                db.Entry(drug).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryId = new SelectList(db.Category, "ID", "CategoryName", drug.CategoryId);
            ViewBag.MedicineId = new SelectList(db.Medicine, "ID", "ID", drug.MedicineId);
            return View(drug);
        }

        // GET: Phamarcy/Drugs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Drug drug = db.Drug.Find(id);
            if (drug == null)
            {
                return HttpNotFound();
            }
            return View(drug);
        }

        // POST: Phamarcy/Drugs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Drug drug = db.Drug.Find(id);
            db.Drug.Remove(drug);
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
