using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class GameController : Controller
    {
        public string Name(string name)
        {
            return "Welcome to " + name;
        }
        public string FullName(string? first=null, string? last=null)
        {
            if(!string.IsNullOrEmpty(first) && string.IsNullOrEmpty(last))
            {
                return "Your First name is = " + first;
            }
            else if(string.IsNullOrEmpty(first) && !string.IsNullOrEmpty(last))
            {
                return "Your Last name is = " + last;
            }
            else
            {
                return "Your first name is = " + first + " and Last name is =" + last;
            }
            
        }
    }
}