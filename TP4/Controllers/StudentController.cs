using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP4.Data;
using TP4.Models;

namespace TP4.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            // test singleton
            var con1 = UniversityContext.getInstance();
            var con2 = UniversityContext.getInstance();
            List<Student> students = con1.Students.ToList();
            return View(students);
        }

        [Route("Home/Test/{course}")]
        public ActionResult SearchStudents(String course)
        {
            var con = UniversityContext.getInstance();
            var repository = new StudentRepository(con);
            var students = repository.GetStudentWithCourse(course).ToList();
            ViewBag.Course = course;
            return View(students);
        }

        public ActionResult Courses()
        {
            var con = UniversityContext.getInstance();
            var repository = new StudentRepository(con);
            var courses = repository.GetCoursesUniques().ToList();
            return View(courses);
        }
    }
}