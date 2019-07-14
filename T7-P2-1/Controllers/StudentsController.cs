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
        [Authorize(Roles = "students")]
        [Route("")]
        [HttpGet]
        public async Task<IEnumerable<Student>> GetStudents()
        {
            // RESULT WILL CAUSE A DEADLOCK!!!!!!!!!!!
            return await studentsService.GetAllStudents();
            // return studentsService.GetAllStudentsFromRepo();
        }

        // GET api/students/actionresult
        [Route("actionresult")]
        [HttpGet]
        public async Task<IHttpActionResult> GetStudentsActionResult()
        {
            // Ok, we now have everything we need for basic functionality
            // We need some plumbing, for example logging and email
            // we can also try to set up those things now or later...
            // we should also try to make an exportable project ready for further work.
            // From start to all models set up, with repos, services, controllers and dtos i think
            // I need some 6-8 hours, mainly recipe following work..
            var students = await studentsService.GetAllStudents();
            return Ok(students);
        }

        [Route("")]
        [HttpPost]
        public IHttpActionResult PostStudent(Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(studentsService.CreateStudent(student));
        }

        [HttpPut]
        [Route("{studentId}/enroll/{classId}")]
        public IHttpActionResult EnrollStudentInClass(string studentId, int classId)
        {
            return Ok(studentsService.EnrollStudentInClass(studentId, classId));
        }
    }
}
