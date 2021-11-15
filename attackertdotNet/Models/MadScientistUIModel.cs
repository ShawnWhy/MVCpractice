using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace attackertdotNet.Models
{
    public class MadScientistUIModel
    {
        [Range(100, 999)]
        [Display(Name = "Badge Number")]
        public int ScientistID { get; set; }
        public string Name { get; set; }
        [Required(ErrorMessage = "Yoe need to input your email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name = "Please Confirm your Email")]
        [Compare("Email", ErrorMessage ="The email and confirm email must match")]
        public string EmailConfirm { get; set; }
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength =8, ErrorMessage ="you need to provice a long enough password")]
        [Required(ErrorMessage ="please enter your password")]
        public string Password { get; set; }
        [Display(Name = "Please Confirm your Password")]
        [Compare("Password", ErrorMessage = "The passwords must match")]
        public string passwordConfirm { get; set; }

    }
}
