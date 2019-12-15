using System;
using System.ComponentModel.DataAnnotations;
using FishAquariumWebApp.Enums;

namespace FishAquariumWebApp.Models
{
    public class AquariumUser
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? BirthDate { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? RegistrationDate { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [DataType("Password")]
        public string Password { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public UserTypes Type { get; set; }
        [Required]
        public int Id { get; set; }
    }
}
