using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GroupProjectCB16.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace GroupProjectCB16.Controllers
{
    public class JobController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Job
        public ActionResult Index()
        {
            if (Request.IsAuthenticated)
            {
                var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
                var currentUser = manager.FindById(User.Identity.GetUserId());
                ViewBag.userId = currentUser.Id;
            }
            GetAllCompanies();
            GetAllUsers();
            return View(db.Jobs.ToList());
        }

        // GET: Job/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Job job = db.Jobs.Find(id);
            if (Request.IsAuthenticated)
            {
                var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
                var currentUser = manager.FindById(User.Identity.GetUserId());
                ViewBag.user = currentUser;
                ViewBag.userJobs = currentUser.Jobs;
            }
            if (job == null)
            {
                return HttpNotFound();
            }
            GetAllCompanies();
            GetAllUsers();
            GetAllJobs();
            return View(job);
        }

        // GET: Job/Create
        [Authorize(Roles = "Company")]
        public ActionResult Create()
        {
           
            return View();
        }

        // POST: Job/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Specialty,Description,WorkPlace,Region,EmploymentType,DatePosted,Salary,User_Id")] Job job)
        {
            if (ModelState.IsValid)
            {
                
                var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
                var currentUser = manager.FindById(User.Identity.GetUserId());
                var company = db.Companies.FirstOrDefault(c => c.User.Id == currentUser.Id);
                db.Jobs.Add(job);
                job.Company = company;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(job);
        }

        // GET: Job/Edit/5
        [Authorize(Roles = "Company")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Job job = db.Jobs.Find(id);
            if (job == null)
            {
                return HttpNotFound();
            }
            return View(job);
        }

        // POST: Job/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Specialty,Description,WorkPlace,Region,EmploymentType,DatePosted,Salary")] Job job)
        {
            if (ModelState.IsValid)
            {
                db.Entry(job).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(job);
        }

        // GET: Job/Delete/5
        [Authorize(Roles ="Company")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Job job = db.Jobs.Find(id);
            if (job == null)
            {
                return HttpNotFound();
            }
            return View(job);
        }

        // POST: Job/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Job job = db.Jobs.Find(id);
            db.Jobs.Remove(job);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "User")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Apply(int id, string userId)
        {
            if (Request.IsAuthenticated)
            {
                var job = db.Jobs.Find(id);
                var user = db.Users.Find(userId);
                user.Jobs.Add(job);
                db.Entry(job).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Details", new { id = id });
            }
            return RedirectToAction("Details", new { id = id });
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        [NonAction]
        public void GetAllCompanies()
        {
            var companies = db.Companies.ToList();
            ViewBag.companies = companies;
        }

        [NonAction]
        public void GetAllUsers()
        {
            var users = db.Users.ToList();
            ViewBag.users = users;
        }

       [NonAction]
       public void GetAllJobs()
        {
            var jobs = db.Jobs.ToList();
            ViewBag.jobs = jobs;
        }

    }
}
