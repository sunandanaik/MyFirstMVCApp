using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult UserData(User user)
        {
            if(ModelState.IsValid)
            {
                return View();
            }
            return View("Index");
            
        }
    }
}