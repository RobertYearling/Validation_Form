using System;
using System.ComponentModel.DataAnnotations;


namespace ValidationForm.Models
{
    public class User
    {
        [Required]
        [MinLength(4)]
        [Display(Name="First Name: ")]
        public string FName { get; set;}

        [Required]
        [MinLength(4)]
        [Display(Name="Last Name: ")]
        public string LName { get; set; }

        [Required]
        [Range(0,150)]
        [Display(Name="Age: ")]
        public string Age { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name="Email: ")]
        public string Email { get; set; }

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [Display(Name="Password: ")]
        public string Password { get; set; }
    }
}