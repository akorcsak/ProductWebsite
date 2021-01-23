using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProductApp.Models;

namespace ProductApp.Controllers
{
    public class ReviewModelsController : Controller
    {
        private DB db = new DB();

        // GET: ReviewModels
        public ActionResult Index()
        {
            return View(db.Reviews.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        // GET: ReviewModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReviewModels reviewModels = db.Reviews.Find(id);
            if (reviewModels == null)
            {
                return HttpNotFound();
            }
            return View(reviewModels);
        }

        // GET: ReviewModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReviewModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,CustomerName,Rating,Description")] ReviewModels reviewModels)
        {
            if (ModelState.IsValid)
            {
                db.Reviews.Add(reviewModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(reviewModels);
        }

        // GET: ReviewModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReviewModels reviewModels = db.Reviews.Find(id);
            if (reviewModels == null)
            {
                return HttpNotFound();
            }
            return View(reviewModels);
        }

        // POST: ReviewModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,CustomerName,Rating,Description")] ReviewModels reviewModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reviewModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(reviewModels);
        }

        // GET: ReviewModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReviewModels reviewModels = db.Reviews.Find(id);
            if (reviewModels == null)
            {
                return HttpNotFound();
            }
            return View(reviewModels);
        }

        // POST: ReviewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ReviewModels reviewModels = db.Reviews.Find(id);
            db.Reviews.Remove(reviewModels);
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
