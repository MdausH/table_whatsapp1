using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using table_whatsapp1.Models;

namespace table_whatsapp1.Controllers
{
    public class Aduan_WhatsappController : Controller
    {
        private meja_bantuanEntities db = new meja_bantuanEntities();

        // GET: Aduan_Whatsapp
        public ActionResult Index()
        {
            return View(db.Aduan_Whatsapp.ToList());
        }

        // GET: Aduan_Whatsapp/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aduan_Whatsapp aduan_Whatsapp = db.Aduan_Whatsapp.Find(id);
            if (aduan_Whatsapp == null)
            {
                return HttpNotFound();
            }
            return View(aduan_Whatsapp);
        }

        // GET: Aduan_Whatsapp/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Aduan_Whatsapp/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,No,Pengadu,Tarikh,Jenis_Aduan,Bahagian,Jenis_Pertanyaan,Aduan,Tindakan,Nama,Status,Tarikh_aduan,Tarikh_selesai")] Aduan_Whatsapp aduan_Whatsapp)
        {
            if (ModelState.IsValid)
            {
                db.Aduan_Whatsapp.Add(aduan_Whatsapp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aduan_Whatsapp);
        }

        // GET: Aduan_Whatsapp/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aduan_Whatsapp aduan_Whatsapp = db.Aduan_Whatsapp.Find(id);
            if (aduan_Whatsapp == null)
            {
                return HttpNotFound();
            }
            return View(aduan_Whatsapp);
        }

        // POST: Aduan_Whatsapp/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,No,Pengadu,Tarikh,Jenis_Aduan,Bahagian,Jenis_Pertanyaan,Aduan,Tindakan,Nama,Status,Tarikh_aduan,Tarikh_selesai")] Aduan_Whatsapp aduan_Whatsapp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aduan_Whatsapp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aduan_Whatsapp);
        }

        // GET: Aduan_Whatsapp/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aduan_Whatsapp aduan_Whatsapp = db.Aduan_Whatsapp.Find(id);
            if (aduan_Whatsapp == null)
            {
                return HttpNotFound();
            }
            return View(aduan_Whatsapp);
        }

        // POST: Aduan_Whatsapp/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Aduan_Whatsapp aduan_Whatsapp = db.Aduan_Whatsapp.Find(id);
            db.Aduan_Whatsapp.Remove(aduan_Whatsapp);
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
