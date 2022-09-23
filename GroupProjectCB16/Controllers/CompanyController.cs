using Entities.Models;
using GroupProjectCB16.Controllers.ControllerHelper;
using GroupProjectCB16.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GroupProjectCB16.Controllers
{
    [Authorize(Roles = "Company")]
    public class CompanyController : Controller
    {
        // GET: Job
        private ApplicationDbContext db = new ApplicationDbContext();

        

        [HttpGet]
        public ActionResult DetailsOf(int? id)
        {
            if (id is null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            var user = db.Users.Find(id);
            if (user is null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.NotFound);
            }
            return View(user);
        }

        [HttpGet]
        public ActionResult UpdateDetailsOfCompany(int? id)
        {
            if(id is null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            var user = db.Users.Find(id);
            if(user is null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.NotFound);
            }
            return View(user);
        }

        [HttpPut]
        public ActionResult UpdateDetailsOfCompany(ApplicationUser user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Attach(user);
                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return Redirect("/Home/Index");
            }

            return View(user);
        }

        //Methods For Admin
        public ActionResult GetAllCompanies()
        {
            var listOfCompanies = db.Users.ToList();

            return Json(listOfCompanies,JsonRequestBehavior.AllowGet);
        }
        //public ActionResult Delete(int? id)
        //{
            
        //    return View(company);
        //}

        [HttpDelete]
        public ActionResult Delete(int? id)
        {
            if (id is null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            var user = db.Users.Find(id);
            if (user is null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.NotFound);
            }
            if (ModelState.IsValid)
            {
                db.Users.Attach(user);
                db.Entry(user).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                return Redirect("/Home/Index");
            }
            return RedirectToAction("Index");
        }


    }
}