using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Models;

namespace TP4.Data
{
    internal interface IStudentRepository : IRepository<Student>
    {
        IEnumerable<Student> GetStudentWithCourse(String c);
        IEnumerable<String> GetCoursesUniques();

    }
}
