using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace T7_P2_1.Repositories
{
    public class RolesRepository : IRolesRepository
    {
        private RoleManager<IdentityRole> _roleManager;

        public RolesRepository(DbContext context)
        {
            _roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
        }

        public async Task<IdentityRole> GetRole(string roleName)
        {
            var role = await _roleManager.FindByNameAsync(roleName);

            return role;
        }

        public void Dispose()
        {
            if (_roleManager != null)
            {
                _roleManager.Dispose();
                _roleManager = null;
            }
        }
    }
}