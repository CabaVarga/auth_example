﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T7_P2_1.Models;
using T7_P2_1.Models.DTOs;

namespace T7_P2_1.Repositories
{
    public interface IAuthRepository : IDisposable
    {
        Task<IdentityResult> RegisterUser(Customer customer, string password);
        Task<IdentityResult> RegisterAdminUser(AdminUser userModel, string password);
        Task<IdentityResult> RegisterStudent(Student student, string password);
        Task<ApplicationUser> FindUser(string userName, string password);
        Task<IList<string>> FindRoles(string userId);

        Task<IdentityRole> GetRole(string roleName);
        // IdentityRole GetRole(string roleName);

        Task<IEnumerable<Student>> GetStudents();
    }
}
