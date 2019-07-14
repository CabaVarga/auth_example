using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using T7_P2_1.Models;
using T7_P2_1.Services;

namespace T7_P2_1.Controllers
{
    [RoutePrefix("api/classes")]
    public class ClassesController : ApiController
    {
        private IClassesService classesService;

        public ClassesController(IClassesService classesService)
        {
            this.classesService = classesService;
        }

        [HttpGet]
        public IHttpActionResult GetClasses()
        {
            return Ok(classesService.GetClasses());
        }

        [Route("{classId}")]
        public IHttpActionResult GetClassById(int classId)
        {
            return Ok(classesService.GetClassById(classId));
        }

        [Route("{classId}")]
        public IHttpActionResult DeleteClass(int classId)
        {
            return Ok(classesService.DeleteClass(classId));
        }

        public IHttpActionResult PostClass(Class newClass)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(classesService.CreateClass(newClass));
        }
    }
}