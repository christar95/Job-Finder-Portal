namespace DataAccessLayer.Migrations
{
    using Entities.Enums;
    using Entities.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccessLayer.ApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DataAccessLayer.ApplicationContext context)
        {
            Job j1 = new Job() { Title = "Junior .NET Developer", Specialty = "Developer", Description = "We are looking for a junior developer with knowledge of .NET CORE", Region = "Athens", DatePosted = new DateTime(2022,08,09),EmploymentType=EmploymentType.FullTime,WorkPlace=WorkPlace.OnSite,Salary=900 };
            Job j2 = new Job() { Title = "Junior .NET Developer", Specialty = "Developer", Description = "We are looking for a junior developer with knowledge of .NET CORE", Region = "Athens", DatePosted = new DateTime(2022,08,09),EmploymentType=EmploymentType.FullTime,WorkPlace=WorkPlace.OnSite,Salary=900 };
            Job j3 = new Job() { Title = "Junior .NET Developer", Specialty = "Developer", Description = "We are looking for a junior developer with knowledge of .NET CORE", Region = "Athens", DatePosted = new DateTime(2022,08,09),EmploymentType=EmploymentType.FullTime,WorkPlace=WorkPlace.OnSite,Salary=900 };
            Company c1 = new Company() { Name = "Intracom", Address = "Faidonos 22", Email = "contact@intacom.gr", Phone = "2101234678" };
            j1.Company = c1;
            j2.Company = c1;
            j3.Company = c1;
            context.Jobs.AddOrUpdate(j1, j2, j3);
            context.SaveChanges();
        }
    }
}
