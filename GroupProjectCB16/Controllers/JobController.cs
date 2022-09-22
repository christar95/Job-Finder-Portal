using Entities.Models;
using GroupProjectCB16.Controllers.ControllerHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GroupProjectCB16.Controllers
{
    public class JobController : BaseController
    {        // GET: Job        public ActionResult Index()        {            return View();        }

        //Company creates Ad
        [Authorize(Roles ="Company")]        
        public ActionResult CreateJobAd()        
        {            
            return View();        
        }

        [HttpPost] 
        public ActionResult CreateJobAd(Job job) 
        { 
            if (ModelState.IsValid) 
            { 
                UnitOfWork.Jobs.Insert(job);
                return Redirect("/Home/Index");
            } 
            return View(job); 
        }

        [HttpGet] 
        public ActionResult ReadAd(int? id) 
        { 
            if (id is null) 
            { 
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest); 
            } 
            var jobAdFromCompany = UnitOfWork.Companies.GetById(id); 
            if (jobAdFromCompany is null) 
            { 
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.NotFound); 
            } 
            return View(jobAdFromCompany); 
        }

        //For AnonymousUsers        
        [HttpGet]        
        public ActionResult GetAllJobAds()        
        {            
            var companyJobs = UnitOfWork.Jobs.GetAll().ToList();
            GetCompanies();
            return View(companyJobs);
        }

        [HttpGet]
        public ActionResult AdDetails(int? id)
        {
            if (id is null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            var job = UnitOfWork.Jobs.GetById(id);
            if (job is null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.NotFound);
            }
            GetCompanies();
            return View(job);
        }

        [HttpGet]
        public ActionResult UpdateAd(int? id) 
        { 
            if (id is null) 
            { 
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest); 
            }
            var AdForUpdate = UnitOfWork.Jobs.GetById(id);
            
            if (AdForUpdate is null) 
            { 
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.NotFound); 
            } 
            return View(AdForUpdate); 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpdateAd(Job jobUpdated)
        {
        if (ModelState.IsValid) { UnitOfWork.Jobs.Update(jobUpdated); return RedirectToAction("GetAllJobAds"); }

            return View(jobUpdated);
        }

        
        /*public ActionResult Delete(int? id) 
        { 
            if (id is null)
            { 
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest); 
            } 
            var AdForDelete = UnitOfWork.Jobs.GetById(id); 
            if (AdForDelete is null) 
            { 
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.NotFound); 
            } 
            return View(AdForDelete); 
        }*/

        /*[HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]*/
        [HttpPost]
        public ActionResult Delete(int? id)
        {
            /*if (id is null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            var AdForDelete = UnitOfWork.Jobs.GetById(id);
            if (AdForDelete is null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.NotFound);
            }*/


            if (ModelState.IsValid)
            {
                UnitOfWork.Jobs.Delete(id);
                return RedirectToAction("GetAllJobAds");
            }
            
            return RedirectToAction("GetAllJobAds");
        }

        [NonAction]
        public void GetCompanies()
        {
            var companies = UnitOfWork.Companies.GetAll();
            ViewBag.companies = companies;
        }

    }
    
}


