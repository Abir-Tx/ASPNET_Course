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
        public string Name { get; set; }

        [Required (ErrorMessage = "The Username is required")]
        public string Username { get; set; }
        [Required (ErrorMessage = "The gender is required")]
        public string Gender { get; set; }
        [Required (ErrorMessage = "You must select a profession")]
        public string[] Profession { get; set; }
        [Required (ErrorMessage = "You must provide your date of birth")]
        public DateTime Dob { get; set; }
        [Required (ErrorMessage = "Student ID is required")]
        public string StudentId { get; set; }
        [Required (ErrorMessage = "Email is required")]
        public string Email { get; set;}
    }
}