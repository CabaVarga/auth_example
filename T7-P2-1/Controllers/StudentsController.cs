using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using T7_P2_1.Models;
using T7_P2_1.Repositories;
using T7_P2_1.Services;

namespace T7_P2_1.Controllers
{
    [RoutePrefix("api/students")]
    public class StudentsController : ApiController
    {
        private IStudentsService studentsService;

        public StudentsController(IStudentsService studentsService)
        {
            this.studentsService = studentsService;
        }

        // GET api/students
        [Route("")]
        [HttpGet]
        public async Task<IEnumerable<Student>> GetStudents()
        {
            // RESULT WILL CAUSE A DEADLOCK!!!!!!!!!!!
            return await studentsService.GetAllStudents();
            // return studentsService.GetAllStudentsFromRepo();
        }
    }
}
