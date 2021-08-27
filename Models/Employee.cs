using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [NameValidation]
        [Display(Name="Please Enter your Name")]
        public string Name { get; set; }
        public string Address { get; set; }
        public bool isEmployee { get; set; }
        [DataType(DataType.Date)]
        public DateTime dob { get; set; }
        
    }
}