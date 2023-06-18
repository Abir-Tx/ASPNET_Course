using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistrationValidation.Models
{
    public class UserModel
    {
        [Required (ErrorMessage = "The Name is required")]
        [Range(1,100,ErrorMessage = "Must be within 100 chars")]
        public string Name { get; set; }

        [Required (ErrorMessage = "The Username is required")]
        [RegularExpression(@"^\S*$", ErrorMessage = "The Username should not contain spaces")]
        [StringLength(20, ErrorMessage = "The Username must be at most 20 characters long")]
        public string Username { get; set; }
        [Required (ErrorMessage = "The gender is required")]
        public string Gender { get; set; }
        [Required (ErrorMessage = "You must select a profession")]
        public string[] Profession { get; set; }

        [Required (ErrorMessage = "You must provide your date of birth")]
        [Range(typeof(DateTime), "1/1/1900", "1/1/2003", ErrorMessage = "The person must be at least 20 years old")]
        public DateTime Dob { get; set; }
        [Required (ErrorMessage = "Student ID is required")]
        [RegularExpression(@"^\d{2}-\d{5}-\d{2}$", ErrorMessage = "The Student ID must follow the format xx-xxxxx-xx")]
        public string StudentId { get; set; }

        [Required (ErrorMessage = "Email is required")]
        [RegularExpression(@"^\d{2}-\d{5}-\d{2}@domain\.edu$", ErrorMessage = "The Student email must follow the format xx-xxxxx-xx@domain.edu")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set;}    
    }
}