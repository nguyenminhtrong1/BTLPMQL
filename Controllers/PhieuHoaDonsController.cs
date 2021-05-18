using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BTLPMQL.Models;

namespace BTLPMQL.Controllers
{
    public class PhieuHoaDonsController : Controller
    {
        private QLShopDbContext db = new QLShopDbContext();

        // GET: PhieuHoaDons
        public ActionResult Index()
        {
            return View(db.PhieuHoaDons.ToList());
        }

        // GET: PhieuHoaDons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhieuHoaDon phieuHoaDon = db.PhieuHoaDons.Find(id);
            if (phieuHoaDon == null)
            {
                return HttpNotFound();
            }
            return View(phieuHoaDon);
        }

        // GET: PhieuHoaDons/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PhieuHoaDons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDphieu,MaPhieu,TenPhieu,SanPham")] PhieuHoaDon phieuHoaDon)
        {
            if (ModelState.IsValid)
            {
                db.PhieuHoaDons.Add(phieuHoaDon);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(phieuHoaDon);
        }

        // GET: PhieuHoaDons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhieuHoaDon phieuHoaDon = db.PhieuHoaDons.Find(id);
            if (phieuHoaDon == null)
            {
                return HttpNotFound();
            }
            return View(phieuHoaDon);
        }

        // POST: PhieuHoaDons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDphieu,MaPhieu,TenPhieu,SanPham")] PhieuHoaDon phieuHoaDon)
        {
            if (ModelState.IsValid)
            {
                db.Entry(phieuHoaDon).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(phieuHoaDon);
        }

        // GET: PhieuHoaDons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhieuHoaDon phieuHoaDon = db.PhieuHoaDons.Find(id);
            if (phieuHoaDon == null)
            {
                return HttpNotFound();
            }
            return View(phieuHoaDon);
        }

        // POST: PhieuHoaDons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PhieuHoaDon phieuHoaDon = db.PhieuHoaDons.Find(id);
            db.PhieuHoaDons.Remove(phieuHoaDon);
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
