using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GroupProjectCB16.Models;

namespace GroupProjectCB16.Controllers
{
    public class JobViewModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: JobViewModels
        public ActionResult Index()
        {
            return View(db.JobViewModels.ToList());
        }

        // GET: JobViewModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobViewModel jobViewModel = db.JobViewModels.Find(id);
            if (jobViewModel == null)
            {
                return HttpNotFound();
            }
            return View(jobViewModel);
        }

        // GET: JobViewModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JobViewModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Specialty,Description,WorkPlace,Region,EmploymentType,DatePosted,Salary,CompanyDetailsId")] JobViewModel jobViewModel)
        {
            if (ModelState.IsValid)
            {
                db.JobViewModels.Add(jobViewModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(jobViewModel);
        }

        // GET: JobViewModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobViewModel jobViewModel = db.JobViewModels.Find(id);
            if (jobViewModel == null)
            {
                return HttpNotFound();
            }
            return View(jobViewModel);
        }

        // POST: JobViewModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Specialty,Description,WorkPlace,Region,EmploymentType,DatePosted,Salary,CompanyDetailsId")] JobViewModel jobViewModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jobViewModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(jobViewModel);
        }

        // GET: JobViewModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobViewModel jobViewModel = db.JobViewModels.Find(id);
            if (jobViewModel == null)
            {
                return HttpNotFound();
            }
            return View(jobViewModel);
        }

        // POST: JobViewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            JobViewModel jobViewModel = db.JobViewModels.Find(id);
            db.JobViewModels.Remove(jobViewModel);
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
