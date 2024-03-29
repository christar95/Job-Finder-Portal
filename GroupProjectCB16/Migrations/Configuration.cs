﻿namespace GroupProjectCB16.Migrations
{
    using Entities.Enums;
    using GroupProjectCB16.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GroupProjectCB16.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(GroupProjectCB16.Models.ApplicationDbContext context)
        {
            #region ApplicationUserSeeding

            //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            //var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            //if (!roleManager.RoleExists("User"))
            //{
            //    var role = new IdentityRole();
            //    role.Name = "User";
            //    roleManager.Create(role);
            //}
            //if (!roleManager.RoleExists("Company"))
            //{
            //    var role = new IdentityRole();
            //    role.Name = "Company";
            //    roleManager.Create(role);
            //}
            //if (!roleManager.RoleExists("Admin"))
            //{
            //    var role = new IdentityRole();
            //    role.Name = "Admin";
            //    roleManager.Create(role);
            //}
            //var passwordHasher = new PasswordHasher();

            //if (!context.Users.Any(x=>x.UserName== "infoath@epsilonnet.gr"))
            //{

            //    var store = new UserStore<ApplicationUser>(context);
            //    var manager = new UserManager<ApplicationUser>(store);
            //    ApplicationUser c1 = new ApplicationUser()
            //    {
            //        Name = "Epsilon Net Group of Companies",
            //        Email = "infoath@epsilonnet.gr",
            //        Address = " 350, Siggrou Avenue, ZIP 176 74 Kalithea",
            //        PasswordHash = passwordHasher.HashPassword("Aa123!")
            //    };
            //    manager.Create(c1);
            //    manager.AddToRole(c1.Id, "Company");
            //}
            //if (!context.Users.Any(x => x.UserName == "karieraSolution@kariera.gr"))
            //{
            //    var store = new UserStore<ApplicationUser>(context);
            //    var manager = new UserManager<ApplicationUser>(store);
            //    ApplicationUser c2 = new ApplicationUser()
            //    {
            //        Name = "Kariera's Hiring Solution’s team",
            //        Email = "karieraSolution@kariera.gr",
            //        Address = "Kastorias 4, Gerakas 153 44",
            //        PasswordHash = passwordHasher.HashPassword("Aa123!")
            //    };
            //    manager.Create(c2);
            //    manager.AddToRole(c2.Id, "Company");
            //}
            //if (!context.Users.Any(x => x.UserName == "sales@papadeas-sa.gr"))
            //{
            //    var store = new UserStore<ApplicationUser>(context);
            //    var manager = new UserManager<ApplicationUser>(store);
            //    ApplicationUser c3 = new ApplicationUser()
            //    {
            //        Name = "ΠΑΠΑΔΕΑΣ Α.Ε.",
            //        Email = "sales@papadeas-sa.gr",
            //        Address = "HROON 1912 4-6 ACHARNAI 136 71 ATHENS GR",
            //        PasswordHash = passwordHasher.HashPassword("Aa123!")
            //    };
            //    manager.Create(c3);
            //    manager.AddToRole(c3.Id, "Company");
            //}
            //if (!context.Users.Any(x => x.UserName == "contact@greeceinvestorguide.com"))
            //{
            //    var store = new UserStore<ApplicationUser>(context);
            //    var manager = new UserManager<ApplicationUser>(store);
            //    ApplicationUser c4 = new ApplicationUser()
            //    {
            //        Name = "ZTE Corporation",
            //        Email = "contact@greeceinvestorguide.com",
            //        Address = "Γράμμου 73, Άγιοι Ανάργυροι (Μαρούσι Αττικής), 151 24 Μαρούσι Αττικής",
            //        PasswordHash = passwordHasher.HashPassword("Aa123!")
            //    };
            //    manager.Create(c4);
            //    manager.AddToRole(c4.Id, "Company");
            //}
            //if (!context.Users.Any(x => x.UserName == "he@kotsovolos.gr"))
            //{
            //    var store = new UserStore<ApplicationUser>(context);
            //    var manager = new UserManager<ApplicationUser>(store);
            //    ApplicationUser c5 = new ApplicationUser()
            //    {
            //        Name = "Kotsovolos",
            //        Email = "he@kotsovolos.gr",
            //        Address = "Μαρίνου Αντύπα 90 T.K.: 14121 Ν.Ηράκλειο Αττικής",
            //        PasswordHash = passwordHasher.HashPassword("Aa123!")
            //    };
            //    manager.Create(c5);
            //    manager.AddToRole(c5.Id, "Company");
            //}
            //if (!context.Users.Any(x => x.UserName == "info@watt-volt.gr"))
            //{
            //    var store = new UserStore<ApplicationUser>(context);
            //    var manager = new UserManager<ApplicationUser>(store);
            //    ApplicationUser c6 = new ApplicationUser()
            //    {
            //        Name = "WATT + VOLT Α.Ε.",
            //        Email = "info@watt-volt.gr",
            //        Address = "Λεωφόρος Κηφισίας 217Α. Μαρούσι 15124",
            //        PasswordHash = passwordHasher.HashPassword("Aa123!")
            //    };
            //    manager.Create(c6);
            //    manager.AddToRole(c6.Id, "Company");
            //}
            //if (!context.Users.Any(x => x.UserName == "info@hemmersbach.com"))
            //{
            //    var store = new UserStore<ApplicationUser>(context);
            //    var manager = new UserManager<ApplicationUser>(store);
            //    ApplicationUser c7 = new ApplicationUser()
            //    {
            //        Name = "HEMMERSBACH HELLAS ONSITE SERVICE M.I.K.E.",
            //        Email = "info@hemmersbach.com",
            //        Address = "Vasilisis Sofias 39, Athens",
            //        PasswordHash = passwordHasher.HashPassword("Aa123!")
            //    };
            //    manager.Create(c7);
            //    manager.AddToRole(c7.Id, "Company");
            //}

            //context.SaveChanges();

            //Job j1 = new Job() { Title = "Junior .NET Developer", Specialty = "Developer", Description = "We are looking for a junior developer with knowledge of .NET CORE", Region = "Athens", DatePosted = new DateTime(2022, 08, 09), EmploymentType = EmploymentType.FullTime, WorkPlace = WorkPlace.OnSite, Salary = 900 };
            //Job j2 = new Job() { Title = "Junior .NET Developer", Specialty = "Developer", Description = "We are looking for a junior developer with knowledge of .NET CORE", Region = "Athens", DatePosted = new DateTime(2022, 08, 09), EmploymentType = EmploymentType.FullTime, WorkPlace = WorkPlace.OnSite, Salary = 900 };
            //Job j3 = new Job() { Title = "Junior .NET Developer", Specialty = "Developer", Description = "We are looking for a junior developer with knowledge of .NET CORE", Region = "Athens", DatePosted = new DateTime(2022, 08, 09), EmploymentType = EmploymentType.FullTime, WorkPlace = WorkPlace.OnSite, Salary = 900 };
            //Job j8 = new Job()
            //{
            //    Title = "Junior. NET Software Engineer",
            //    Description = "Epsilon Net Group of Companies, awarded with 7 Nationals and 2 European Best Workplace awards, is seeking for a passionate Junior. NET Software Engineer to join our dynamic team and meet the department’s needs. The Junior. NET Software Engineer will be responsible for developing code powering EPSILON NET Group's web applications",
            //    DatePosted = DateTime.Now,
            //    Salary = 900,
            //    EmploymentType = EmploymentType.FullTime,
            //    WorkPlace = WorkPlace.Remote,
            //    Specialty = "Software Engineer"
            //};
            //Job j9 = new Job()
            //{
            //    Title = "Network Engineer",
            //    Description = "Kariera's Hiring Solution’s team is looking on behalf of Marpoint, a leading System Integrator and Satellite communication company operating mainly in the Maritime Industry, for a self-motivated and highly professional individual to fulfill the position of Network Engineer/ Technical Support.",
            //    DatePosted = DateTime.Now,
            //    EmploymentType = EmploymentType.FullTime,
            //    WorkPlace = WorkPlace.Remote,
            //    Specialty = "Network Engineering"
            //};
            //Job j10 = new Job()
            //{
            //    Title = "Junior System and Network Administrator",
            //    Description = "Η εταιρία ΠΑΠΑΔΕΑΣ Α.Ε. ιδρύθηκε το 1985 και είναι η μεγαλύτερη εταιρία εισαγωγής και διακίνησης βιομηχανικών εργαλείων και σιδηρικών στην Ελλάδα. Καθιερώθηκε στο χονδρικό εμπόριο ως πρωτοπόρος και καινοτόμος με άμεση διανομή και διαρκή διαθεσιμότητα, παρέχοντας αξιόπιστες υπηρεσίες. Καθημερινά, προμηθεύει τα συνεργαζόμενα καταστήματα λιανικής πώλησης σε Ελλάδα, Κύπρο & Βαλκάνια. Στο πλαίσιο της συνεχούς ανάπτυξης η εταιρεία αναζητά:",
            //    DatePosted = DateTime.Now,
            //    Salary = 850,
            //    EmploymentType = EmploymentType.FullTime,
            //    WorkPlace = WorkPlace.OnSite,
            //    Specialty = "System and Network"
            //};
            //Job j4 = new Job()
            //{
            //    Title = "Fixed Network Engineer",
            //    Description = "ZTE Corporation is a global leader in telecommunications and information technology. Founded in 1985 and listed on both the Hong Kong and Shenzhen Stock Exchanges, the company has been committed to providing integrated end-to-end innovations to deliver excellence and value to consumers, carriers, businesses and public sector customers from over 160 countries around the world to enable increased connectivity and productivity.",
            //    DatePosted = DateTime.Now,
            //    Salary = 999,
            //    EmploymentType = EmploymentType.PartTime,
            //    WorkPlace = WorkPlace.OnSite,
            //    Specialty = "Network Engineer"
            //};
            //Job j5 = new Job()
            //{
            //    Title = "IT Network DevOps Engineer",
            //    Description = "In Kotsovolos, a member of Currys group, we believe in everything you have to offer. That’s why here, you will find a company that focuses on technology and innovation, but first of all believes and seeks the continuous development of its 2.800 people. In numbers! 94 stores, 2 modern training centers and more than 50.000 hours of training per year, dedicated to our people. Our goal? To plan for tomorrow and be the first ones who bring new technologies that will make our lives better.",
            //    DatePosted = DateTime.Now,
            //    EmploymentType = EmploymentType.FullTime,
            //    WorkPlace = WorkPlace.OnSite,
            //    Specialty = "DevOps Engineer"
            //};
            //Job j6 = new Job()
            //{
            //    Title = "Retail Sales Advisor (ΝΕΑ ΙΩΝΙΑ)",
            //    Description = "Η WATT + VOLT Α.Ε. είναι μία από τις μεγαλύτερες εταιρείες παροχής ολοκληρωμένων υπηρεσιών ηλεκτρικής ενέργειας στην Ελλάδα και συγκαταλέγεται ανάμεσα στις 1000 ταχύτερα αναπτυσσόμενες εταιρείες της Ευρώπης σύμφωνα με το FT1000 Report των Financial Times.Σε έναν κόσμο που μεταβάλλεται διαρκώς, το όραμα της WATT + VOLT είναι να βρίσκεται πάντα σε θέση να προσφέρει σε κάθε Έλληνα καταναλωτή καινοτόμες υπηρεσίες,προσαρμοσμένες στις δικές του ανάγκες, με σεβασμό στο περιβάλλον και εφόδια την υψηλή τεχνολογική υποδομή,  την τεχνογνωσία και την εξειδίκευση του ανθρώπινου δυναμικού Στο πλαίσιο της δυναμικής ανάπτυξης των δραστηριοτήτων της,η WATT + VOLT αναζητά Retail Sales Advisor για το ιδιόκτητο κατάστημά της στην ΝΕΑ ΙΩΝΙΑ.",
            //    DatePosted = DateTime.Now,
            //    EmploymentType = EmploymentType.FullTime,
            //    WorkPlace = WorkPlace.OnSite,
            //    Specialty = "Salesman",
            //};
            //Job j7 = new Job()
            //{
            //    Title = "German Account Manager (m/f/d)",
            //    Description = "Hemmersbach provides IT infrastructure services in more than 190 countries with 50 own subsidiaries. We deliver exclusively for the leading companies in the IT industry. We go the extra mile – we not only simply enthuse our customers, but also make the world a better place: 20% of our profits go into our Direct Actions Hemmersbach Rhino Force, Hemmersbach Kids’ Family and Hemmersbach Climate Force. That’s why Hemmersbach is The Social Purpose IT ApplicationUser.",
            //    DatePosted = DateTime.Now,
            //    EmploymentType = EmploymentType.FullTime,
            //    WorkPlace = WorkPlace.Remote,
            //    Specialty = "Account Manager"
            //};
            //context.Jobs.AddOrUpdate(x => x.Title, j1, j2, j3, j4, j5, j6, j7, j8, j9, j10);
            //context.SaveChanges();

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


                #endregion

            }
    }
}
