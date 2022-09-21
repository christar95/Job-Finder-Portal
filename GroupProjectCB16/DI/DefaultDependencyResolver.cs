using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;
using System.Web.Mvc;

namespace GroupProjectCB16.DI
{
    public class DefaultDependencyResolver : System.Web.Mvc.IDependencyResolver
    {
        protected IServiceProvider serviceProvider;

        public DefaultDependencyResolver(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public object GetService(Type serviceType)
        {
            return this.serviceProvider.GetService(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return this.serviceProvider.GetServices(serviceType);
        }

       
    }
}