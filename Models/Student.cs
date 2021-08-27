using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string course { get; set; }
        public Address address { get; set; }
    }
}