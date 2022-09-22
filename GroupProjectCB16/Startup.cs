using GroupProjectCB16.DI;
using GroupProjectCB16.Infrastracture.Interfaces;
using GroupProjectCB16.Infrastracture.Services;
using GroupProjectCB16.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
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
            CreateRolesAndUsers();

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
                       .Where(t => typeof(IController).IsAssignableFrom(t)
                            || t.Name.EndsWith("Controller", StringComparison.OrdinalIgnoreCase)));

            //Registering the rest of the services.
            services.AddTransient<IJobService, JobService>();
        }

        private void CreateRolesAndUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            if (!roleManager.RoleExists("User"))
            {
                var role = new IdentityRole();
                role.Name = "User";
                roleManager.Create(role);
            }
            if (!roleManager.RoleExists("Company"))
            {
                var role = new IdentityRole();
                role.Name = "Company";
                roleManager.Create(role);
            }
            if (!roleManager.RoleExists("Admin"))
            {
                var role = new IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);
            }
        }

    }
}
