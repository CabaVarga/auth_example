using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using T7_P2_1.Models;
using T7_P2_1.Repositories;

namespace T7_P2_1.Services
{
    public class ClassesService : IClassesService
    {
        private IUnitOfWork db;

        public ClassesService(IUnitOfWork db)
        {
            this.db = db;
        }

        public Class CreateClass(Class newClass)
        {
            db.ClassesRepository.Insert(newClass);
            db.Save();
            return newClass;
        }

        public Class DeleteClass(int id)
        {
            Class classToDelete = db.ClassesRepository.GetByID(id);

            if (classToDelete != null)
            {
                db.ClassesRepository.Delete(classToDelete);
                db.Save();
            }

            return classToDelete;
        }

        public Class GetClassById(int id)
        {
            return db.ClassesRepository.GetByID(id);
        }

        public IEnumerable<Class> GetClasses()
        {
            return db.ClassesRepository.Get();
        }
    }
}