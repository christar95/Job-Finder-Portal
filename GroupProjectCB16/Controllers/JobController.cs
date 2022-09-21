﻿using Entities.Models;
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
            } 
            return View(); 
        }

        [HttpGet] public ActionResult ReadAd(int? id) 
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

            return View(companyJobs);
        }

        public ActionResult UpdateAd(int? id) 
        { 
            if (id is null) 
            { 
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest); 
            } 
            var AdForUpdate = UnitOfWork.Companies.GetById(id); 
            if (AdForUpdate is null) 
            { 
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.NotFound); 
            } 
            return View(AdForUpdate); 
        }

        [HttpPut]
        public ActionResult UpdateAdConfirmed(Job jobUpdated)
        {
        if (ModelState.IsValid) { UnitOfWork.Jobs.Insert(jobUpdated); }

        return RedirectToAction("Index");
        }

        public ActionResult Delete(int? id) 
        { 
            if (id is null)
            { 
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest); 
            } 
            var AdForDelete = UnitOfWork.Companies.GetById(id); 
            if (AdForDelete is null) 
            { 
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.NotFound); 
            } 
            return View(AdForDelete); 
        }

        [HttpDelete]
        public ActionResult DeleteConfirmed(Job jobDeleted)
        {
        if (ModelState.IsValid) { UnitOfWork.Jobs.Delete(jobDeleted); }

        return RedirectToAction("Index");
        }
    }
    
}


