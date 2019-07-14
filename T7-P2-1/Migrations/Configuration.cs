namespace T7_P2_1.Migrations
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Security.Claims;
    using T7_P2_1.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<T7_P2_1.Infrastructure.AuthContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(T7_P2_1.Infrastructure.AuthContext context)
        {
            //IdentityRole roleAdmins = new IdentityRole() { Name = "admins" };
            //context.Roles.AddOrUpdate(roleAdmins);

            //IdentityRole roleStudents = new IdentityRole() { Name = "students" };
            //context.Roles.AddOrUpdate(roleStudents);

            //IdentityRole roleCustomers = new IdentityRole() { Name = "customers" };
            //context.Roles.AddOrUpdate(roleCustomers);

            IdentityRole roleUsers = new IdentityRole() { Name = "users" };
            context.Roles.AddOrUpdate(roleUsers);

            //Student s1 = new Student()
            //{
            //    UserName = "studentOne",
            //    FirstName = "caba",
            //    LastName = "varga",
            //    NickName = "gabber"
            //};

            //context.Users.AddOrUpdate(s1);

            //IdentityUserClaim identityUserClaim = new IdentityUserClaim()
            //{
            //    ClaimType = ClaimTypes.Role,
            //    ClaimValue = "students",
            //    UserId = s1.Id
            //};

            // Nope, you can't add roles or claims directly
            // you don't even have any access to them

        }
    }
}
