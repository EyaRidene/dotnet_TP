using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using TP4.Models;

namespace TP4.Data
{
    public class StudentRepository : Repository<Student> , IStudentRepository
    {
        private readonly UniversityContext context;

        public StudentRepository(UniversityContext context) : base(context) 
        {
            this.context = context;
        }
        public IEnumerable<Student> GetStudentWithCourse(String c)
        {
            return context.Students.Where(s => s.course == c);
        }

        public IEnumerable<String> GetCoursesUniques() 
        {
            return context.Students.Select(e => e.course).ToList();
        }
    }
}