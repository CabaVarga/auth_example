using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using T7_P2_1.Models;

namespace T7_P2_1.Services
{
    public interface IStudentsService
    {
        Task<IEnumerable<Student>> GetAllStudents();
        IEnumerable<Student> GetAllStudentsFromRepo();

        Student CreateStudent(Student student);

        Student EnrollStudentInClass(string studentId, int classId);
    }
}