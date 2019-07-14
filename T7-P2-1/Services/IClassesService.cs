using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using T7_P2_1.Models;

namespace T7_P2_1.Services
{
    public interface IClassesService
    {
        IEnumerable<Class> GetClasses();
        Class GetClassById(int id);

        Class CreateClass(Class newClass);
        Class DeleteClass(int id);
    }
}