using GroupProjectCB16.DI;
using GroupProjectCB16.Infrastracture.Interfaces;
using GroupProjectCB16.Infrastracture.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Owin;
using Owin;
using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.Services.Description;

[assembly: OwinStartupAttribute(typeof(GroupProjectCB16.Startup))]
namespace GroupProjectCB16
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            var services = new Microsoft.Extensions.DependencyInjection.ServiceCollection();
            ConfigureServices(services);


            //This is a default dependency resolver to resolve/get registered services
            var resolver = new DefaultDependencyResolver(services.BuildServiceProvider());
            //Here I register my custom dependency resolver which contains my DI container(services)
            DependencyResolver.SetResolver(resolver);
        }
        public void ConfigureServices(IServiceCollection services)
        {
            //Registering controllers(without this the controllers will NOT run, so do not remove this)
            services.AddControllersAsServices(typeof(Startup).Assembly.GetExportedTypes()
                       .Where(t => !t.IsAbstract && !t.IsGenericTypeDefinition)
                       .Where(t => typeof(Controller).IsAssignableFrom(t)
                            || t.Name.EndsWith("Controller", StringComparison.OrdinalIgnoreCase)));

            //Registering the rest of the services.
            services.AddScoped<IJobService, JobService>();
        }

    }
}
