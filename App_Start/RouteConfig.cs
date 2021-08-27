using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication3
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //TO use Attribute Routing
            routes.MapMvcAttributeRoutes();

            //TO make more routes to use Conventional or Traditional Routing.
            /*routes.MapRoute(
                name: "AllStudents",
                url: "students",
                defaults: new { controller = "Student", action = "GetAllStudent" }
                );

            routes.MapRoute(
                name: "Student",
                url: "students/{id}",
                defaults: new { controller = "Student", action = "GetOneStudent" },
                constraints: new { id = @"\d+" } //use regex
                );

            routes.MapRoute(
                name: "StudentAddress",
                url: "students/{id}/Address",
                defaults: new { controller = "Student", action = "GetStudentAddress" },
                constraints: new {id=@"\d+"} //use regex
                );
            */
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
