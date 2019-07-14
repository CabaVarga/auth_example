using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace T7_P2_1.Repositories
{
    public interface IRolesRepository : IDisposable
    {
        Task<IdentityRole> GetRole(string roleName);
    }
}