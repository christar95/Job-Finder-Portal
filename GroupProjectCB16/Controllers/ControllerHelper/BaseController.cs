using DataAccessLayer;
using RepositoryServices.Core;
using RepositoryServices.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GroupProjectCB16.Controllers.ControllerHelper
{
    public class BaseController : Controller
    {
        protected IUnitOfWork UnitOfWork;
        protected ApplicationContext db = new ApplicationContext();
        public BaseController()
        {
            UnitOfWork = new UnitOfWork(db);
        }
    }
}