using System;
using System.ComponentModel.DataAnnotations;
using FishAquariumWebApp.Enums;

namespace FishAquariumWebApp.Models
{
    

    public class Food
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public double? Mass { get; set; }
        [Required]
        public double? Calories { get; set; }
        [Required]
        public double? Carbs { get; set; }
        [Required]
        public double? Proten { get; set; }
        [Required]
        public double? Fat { get; set; }
        [Required]
        public string PrepManual { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? ExpirationDate { get; set; }
        public AllergenTypes Allergen { get; set; }
        public int Id { get; set; }
    }
}
