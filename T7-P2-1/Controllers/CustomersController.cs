using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using T7_P2_1.Models;
using T7_P2_1.Services;

namespace T7_P2_1.Controllers
{
    public class CustomersController : ApiController
    {
        private IUserService userService;

        public CustomersController(IUserService userService)
        {
            this.userService = userService;
        }

        [Route("api/customers")]
        public IEnumerable<Customer> GetCustomers()
        {
            return userService.GetAllCustomers();
        }
    }
}
