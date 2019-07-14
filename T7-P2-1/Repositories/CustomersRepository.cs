using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using T7_P2_1.Infrastructure;
using T7_P2_1.Models;

namespace T7_P2_1.Repositories
{
    public class CustomersRepository : ICustomersRepository
    {
        private AuthContext ctx;

        public CustomersRepository(AuthContext ctx)
        {
            this.ctx = ctx;
        }

        public IEnumerable<Customer> Get()
        {
            return ctx.Users.OfType<Customer>();
        }
    }
}