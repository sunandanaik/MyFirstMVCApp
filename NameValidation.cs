using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3
{
    public class NameValidation:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value != null)
            {
                string name = value.ToString();
                if(name.Contains("hrutika"))
                {
                    return ValidationResult.Success;
                }
                
            }
            ErrorMessage = ErrorMessage ?? validationContext.DisplayName+" Field must contain hrutika."; //?? used to check for null value
            return new ValidationResult(ErrorMessage);
        }
    }
}