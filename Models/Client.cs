using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Client
    {
        [Display(Name = "First Name:")]
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Display(Name = "Email Address:")]
        [Required]
        [EmailAddress(ErrorMessage ="Enter Valid Email ID")]
        public string Email { get; set; }

        [Display(Name = "Age:")]
        [Required]
        [Range(10,100)]
        public int Age { get; set; }

        [Display(Name = "City:")]
        [Required]
        public string city { get; set; }
    }
}