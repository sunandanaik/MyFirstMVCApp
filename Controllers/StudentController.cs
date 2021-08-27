using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;


namespace WebApplication3.Controllers
{
    [RoutePrefix("students")] //to define once at controller level instead of using it repeatedly.
    public class StudentController : Controller
    {
        // GET: Student
        [Route("")]
        public ActionResult GetAllStudent()
        {
            var students = GetStudents();
            return View(students);
        }

        [Route("{id}")]
        public ActionResult GetOneStudent(int id)
        {
            var students = GetStudents().FirstOrDefault(e=>e.Id == id); //gives first record from Student Model
            return View(students);
        }

        [Route("{id}/Address")]
        public ActionResult GetStudentAddress(int id)
        {
            var studentsAdd = GetStudents().Where(e => e.Id == id).Select(e => e.address).FirstOrDefault(); //this gives a single record
            return View(studentsAdd);
        }

        //Now if you dont want routeprefix for one of the AM to be used, then you can override
        [Route("~/aboutus")]
        public string AboutUs()
        {
            return "This is About Us page";
        }

        //Students Data created here instead of Database
        private List<Student> GetStudents()
        {
            var students= new List<Student>
            {
                new Student()
                {
                    Id=1,Name="Mark",course="Reactjs",address=new Address()
                    {
                        houseno="F2",street="purple street",city="New York"
                    }
                },
                new Student()
                {
                    Id=2,Name="John",course="ASP",address=new Address()
                    {
                        houseno="F1",street="red street",city="Mexico"
                    }
                }
            };
            return students;
        }
    }
}