using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace T7_P2_1.Infrastructure
{
    public class Initialize : DropCreateDatabaseAlways<AuthContext>
    {
        protected override void Seed(AuthContext context)
        {
            IdentityRole roleAdmins = new IdentityRole() { Name = "admins" };
            context.Roles.Add(roleAdmins);

            IdentityRole roleStudents = new IdentityRole() { Name = "students" };
            context.Roles.Add(roleStudents);

            context.SaveChanges();

            base.Seed(context);
        }
    }
}