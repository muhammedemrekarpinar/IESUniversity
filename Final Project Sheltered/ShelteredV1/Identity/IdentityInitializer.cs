using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using ShelteredV1.Entity;

namespace ShelteredV1.Identity
{
    public class IdentityInitializer : CreateDatabaseIfNotExists<IdentityDataContext>
    {
        protected override void Seed(IdentityDataContext context)
        {
            //Roller
            if (!context.Roles.Any(i => i.Name == "Admin"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager =new RoleManager<ApplicationRole>(store);

                var role = new ApplicationRole(){Name = "admin",Description = "Admin Rolü"};
                manager.Create(role);

            }
            if (!context.Roles.Any(i => i.Name == "user"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);

                var role = new ApplicationRole(){Name = "user",Description = "User Rolü"};
                manager.Create(role);

            }
            if (!context.Users.Any(i => i.Name == "MEK"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser(){Name = "Muhammed Emre",Surname = "KARPINAR",UserName = "MEK",Email = "muhammedemrekarpinar@gmail.com"};
                manager.Create(user,"2011100088");
                manager.AddToRole(user.Id, "admin");
                manager.AddToRole(user.Id, "user");
            }
            if (!context.Users.Any(i => i.Name == "HK"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser() { Name = "Hasan", Surname = "KARPINAR", UserName = "HK", Email = "hasankarpinar@gmail.com" };
                manager.Create(user, "1923722486");
                manager.AddToRole(user.Id, "user");
            }










            base.Seed(context);
        }
    }
}