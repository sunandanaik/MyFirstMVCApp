using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class EmployeeController : Controller
    {

        public string EmpProfile(int? id=null)
        {
            string profile = string.Empty;
            if(id == 1)
            {
                profile = "Employee 1";
            }
            else if(id == 2)
            {
                profile = "Employee 2";
            }
            else
            {
                profile = "Employee not found";
            }
            return profile;
        }
        //to make parameter nullable, we provide default value
        public string Address(int id, string? dept=null)
        {
            return "id = " + id + " and Department is= " + dept;
        }

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Employee emp)
        {
            if(ModelState.IsValid)
            {
                ModelState.Clear();
                return View();
            }
            return View();
        }

        [Route("Employees")]
        public ActionResult GetEmployee()
        {
            return View("GetEmployee","_layout"); //Here View file and layout file is mentioned in arguments.
        }
        [Route("AddEmployees")]
        public ActionResult AddEmployee()
        {
            return View("AddEmployee","_Layout2");
        }
    }
}