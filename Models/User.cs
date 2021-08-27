using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class User
    {
        [Display(Name = "First Name:")]
        [Required(ErrorMessage = "FirstName is required.")]
        [StringLength(50, ErrorMessage = "The First Name must be less than {1} characters.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name:")]
        [Required(ErrorMessage = "LastName is required.")]
        [StringLength(50, ErrorMessage = "The Last Name must be less than {1} characters.")]
        public string LastName { get; set; }

        [Display(Name = "Email Address:")]
        [Required]
        [EmailAddress(ErrorMessage = "Enter Valid Email ID")]
        public string Email { get; set; }

        [Display(Name = "Age:")]
        [Required]
        [Range(10, 100)]
        public int Age { get; set; }

        [Display(Name = "City:")]
        [Required]
        public string city { get; set; }
    }
}