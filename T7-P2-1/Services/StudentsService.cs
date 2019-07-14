using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using T7_P2_1.Models;
using T7_P2_1.Repositories;

namespace T7_P2_1.Services
{
    public class StudentsService : IStudentsService
    {
        private IUnitOfWork db;

        public StudentsService(IUnitOfWork db)
        {
            this.db = db;
        }

        public Student CreateStudent(Student student)
        {
            db.UsersRepository.Insert(student);
            db.Save();

            return student;
        }

        public Student EnrollStudentInClass(string studentId, int classId)
        {
            Student student = (Student)db.UsersRepository.GetByID(studentId);

            if (student == null)
            {
                return null;
            }

            Class schoolClass = db.ClassesRepository.GetByID(classId);

            if (schoolClass == null)
            {
                return null;
            }

            student.Class = schoolClass;
            db.Save();

            return student;
        }

        public async Task<IEnumerable<Student>> GetAllStudents()
        {
            //// We need either a RoleStore etc implementation or we need to do other stuff...

            //IdentityRole role = await db.RolesRepository.GetRole("students");
            //// IdentityRole role = db.AuthRepository.GetRole("students");







            //// Find all users currently in database
            //var users = db.UsersRepository.Get();

            //foreach (var user in users)
            //{
            //    if (user is Student)
            //    {
            //        var studentUser = user as Student;
            //        Debug.WriteLine("The user is a student");
            //        Debug.WriteLine("His nickname is: " + studentUser.NickName);
            //    }
            //    Debug.WriteLine(user.UserName);
            //}

            //// So basically this is the natural approach
            //// I should make a few changes to GenericRepo to allow filtering in query
            //// I do not need all users pulled in every query...
            //var users2 = db.UsersRepository.Get().OfType<Student>();














            //if (role == null)
            //{
            //    return null;
            //}

            //role = await db.AuthRepository.GetRole("students");

            //var something = await db.AuthRepository.FindUser("csaba", "ddd");

            //IEnumerable<Student> students = db.UsersRepository.Get(u => u.Roles.Any(r => r.RoleId == role.Id)).Select(s =>
            //new Student
            //{
            //    // Convert user to student or studentdto...
            //});

            var students = db.UsersRepository.Get().OfType<Student>().ToList();

            return students;
        }

        public IEnumerable<Student> GetAllStudentsFromRepo()
        {
            
            return db.StudentsRepository.Get();
        }
    }
}