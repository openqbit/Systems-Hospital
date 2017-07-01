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
    public class PharmacyOrdersDetailsController : Controller
    {
        private PharmacyContext db = new PharmacyContext();

        // GET: Phamarcy/PharmacyOrdersDetails
        public ActionResult Index()
        {
            return View(db.PharmacyOrdersDetail.ToList());
        }

        // GET: Phamarcy/PharmacyOrdersDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PharmacyOrdersDetail pharmacyOrdersDetail = db.PharmacyOrdersDetail.Find(id);
            if (pharmacyOrdersDetail == null)
            {
                return HttpNotFound();
            }
            return View(pharmacyOrdersDetail);
        }

        // GET: Phamarcy/PharmacyOrdersDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Phamarcy/PharmacyOrdersDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,OrderQty,ItemName,UnitPrice,ItemTotalPrice")] PharmacyOrdersDetail pharmacyOrdersDetail)
        {
            if (ModelState.IsValid)
            {
                db.PharmacyOrdersDetail.Add(pharmacyOrdersDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pharmacyOrdersDetail);
        }

        // GET: Phamarcy/PharmacyOrdersDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PharmacyOrdersDetail pharmacyOrdersDetail = db.PharmacyOrdersDetail.Find(id);
            if (pharmacyOrdersDetail == null)
            {
                return HttpNotFound();
            }
            return View(pharmacyOrdersDetail);
        }

        // POST: Phamarcy/PharmacyOrdersDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,OrderQty,ItemName,UnitPrice,ItemTotalPrice")] PharmacyOrdersDetail pharmacyOrdersDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pharmacyOrdersDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pharmacyOrdersDetail);
        }

        // GET: Phamarcy/PharmacyOrdersDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PharmacyOrdersDetail pharmacyOrdersDetail = db.PharmacyOrdersDetail.Find(id);
            if (pharmacyOrdersDetail == null)
            {
                return HttpNotFound();
            }
            return View(pharmacyOrdersDetail);
        }

        // POST: Phamarcy/PharmacyOrdersDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PharmacyOrdersDetail pharmacyOrdersDetail = db.PharmacyOrdersDetail.Find(id);
            db.PharmacyOrdersDetail.Remove(pharmacyOrdersDetail);
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
