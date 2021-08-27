using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
using Newtonsoft.Json;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Index()
        {
            TempData["tKey"] = "Sunanda Blog";
            var empData = GetEmployee();
            return View(empData);
        }
        public ActionResult Feature()
        {
            return View();
        }
        public ActionResult Details()
        {
            Employee emp = new Employee();
            emp.Id = 201;
            emp.Name = "Alexa";
            emp.Address = "America";
            emp.isEmployee = true;
            return View(emp);
        }
        //To Get Data
        [HttpGet]
        public ActionResult Person()
        {
            return View();
        }

        [HttpPost]
        public string PersonData(string fname, string lname)
        {
            return "From parameters :"+fname+ " "+lname;
        }

        [HttpPost]
        public string PersonDataReq()
        {
            string n1 = Request["fname"];
            string n2 = Request["lname"];
            return "From request :" + n1 + " " + n2;
        }

        [HttpPost]
        public string PersonDataForm(FormCollection form)
        {
            string n1 = form["fname"];
            string n2 = form["lname"];
            return "From form :" + n1 + " " + n2;
        }
        [HttpPost]
        public string PersonDataBind(Employee emp)
        {
            return "From Bind :" + emp.Name;
        }

        //POST method
        [HttpPost]
        public ActionResult Details(Employee emp)
        {
            return View();
        }
        public ActionResult Edit()
        {
            return View();
        }
        //Post data
        [HttpPost]
        public ActionResult Edit(Employee emp)
        {
            return View();
        }
        public ActionResult About()
        {
            //Using ViewBag-used to pass data from controller to View
            ViewBag.FullName = "Hrutika Naik";
            ViewBag.colorList = new List<string>() { "red", "green", "blue", "yellow" };
            List<Employee> emp = new List<Employee>()
            {
                new Employee(){Id=101,Name="Siri",Address="USA",isEmployee=true,dob=DateTime.Now},
                new Employee(){Id=102,Name="Alexa",Address="Japan",isEmployee=false,dob=DateTime.Now},
                new Employee(){Id=103,Name="Cortana",Address="China",isEmployee=true,dob=DateTime.Now},
            };
            ViewBag.empList = emp;
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.TKey = TempData["tKey"];
            TempData.Keep("tkey");
            
            //Using ViewData as Dictionary to pass data from controller to View.
            ViewData["marks"] = "89";
            ViewData["colors"]= new List<string>() { "red", "green", "blue", "yellow" };
            return View();
        }
        public ActionResult Blog()
        {
            ViewBag.TKey = TempData["tKey"];
            TempData.Keep("tkey");
            //OR using Peek()
            //ViewBag.TKey = TempData.Peek("tKey");
            return View();
        }
        public string Greet()
        {
            return "Welcome to Asp.Net MVC World!!!";
        }

        public string Name()
        {
            return "My name is Sunanda Naik";
        }
        private Employee GetEmployee()
        {
            return new Employee()
            {
                Id = 1,
                Name = "Steve Smith",
                Address = "India",
                isEmployee=true,
                dob=DateTime.Now
                
            };
        }

        public JsonResult GetStudent()
        {
            Student stud = new Student()
            {
                Id = 1,
                Name = "Jeff Boss",
                course = "Java",
                address = new Address()
                {
                    houseno="F2",
                    street="purple",
                    city="USA"
                }
            };
            //Now convert stud object into JSON Using NewtonSoft.Json pkg.
            var json = JsonConvert.SerializeObject(stud); //Converts object into json string
            return Json(json, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult AddStudent(Student stud)
        {
            return Json("true", JsonRequestBehavior.AllowGet);
        }
    }
}