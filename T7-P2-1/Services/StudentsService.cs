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

        public async Task<IEnumerable<Student>> GetAllStudents()
        {
            // We need either a RoleStore etc implementation or we need to do other stuff...

            IdentityRole role = await db.RolesRepository.GetRole("students");
            // IdentityRole role = db.AuthRepository.GetRole("students");







            // Find all users currently in database
            var users = db.UsersRepository.Get();

            foreach (var user in users)
            {
                if (user is Student)
                {
                    var studentUser = user as Student;
                    Debug.WriteLine("The user is a student");
                    Debug.WriteLine("His nickname is: " + studentUser.NickName);
                }
                Debug.WriteLine(user.UserName);
            }














            if (role == null)
            {
                return null;
            }

            role = await db.AuthRepository.GetRole("students");

            var something = await db.AuthRepository.FindUser("csaba", "ddd");

            IEnumerable<Student> students = db.UsersRepository.Get(u => u.Roles.Any(r => r.RoleId == role.Id)).Select(s =>
            new Student
            {
                // Convert user to student or studentdto...
            });

            return students;
        }

        public IEnumerable<Student> GetAllStudentsFromRepo()
        {
            
            return db.StudentsRepository.Get();
        }
    }
}