using Entities.Models;
using GroupProjectCB16.Controllers.ControllerHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GroupProjectCB16.Controllers
{
    [Authorize(Roles = "Company")]
    public class CompanyController : BaseController
    {
        // GET: Job
       

        [HttpGet]
        public ActionResult DetailsOf(int? id)
        {
            if (id is null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            var company = UnitOfWork.Companies.GetById(id);
            if (company is null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.NotFound);
            }
            return View(company);
        }

        [HttpGet]
        public ActionResult UpdateDetailsOfCompany(int? id)
        {
            if(id is null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            var company = UnitOfWork.Companies.GetById(id);
            if(company is null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.NotFound);
            }
            return View(company);
        }

        [HttpPut]
        public ActionResult UpdateDetailsOfCompany(Company company)
        {
            if (ModelState.IsValid)
            {
                UnitOfWork.Companies.Update(company);
                return Redirect("/Home/Index");
            }

            return View(company);
        }

        //Methods For Admin
        public ActionResult GetAllCompanies()
        {
            var listOfCompanies = UnitOfWork.Companies.GetAll().ToList();

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
            var company = UnitOfWork.Companies.GetById(id);
            if (company is null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.NotFound);
            }
            if (ModelState.IsValid)
            {
                UnitOfWork.Companies.Delete(company);
            }
            return RedirectToAction("Index");
        }


    }
}