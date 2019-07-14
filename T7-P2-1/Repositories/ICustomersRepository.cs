using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using T7_P2_1.Models;

namespace T7_P2_1.Repositories
{
    public interface ICustomersRepository
    {
        IEnumerable<Customer> Get();
    }
}