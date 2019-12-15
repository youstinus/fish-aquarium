using System;
using System.ComponentModel.DataAnnotations;
using FishAquariumWebApp.Enums;

namespace FishAquariumWebApp.Models
{
    

    public class Food
    {
        [Required]
        public string Name { get; set; }
        public double? Mass { get; set; }
        public double? Calories { get; set; }
        public double? Carbs { get; set; }
        public double? Proten { get; set; }
        public double? Fat { get; set; }
        public string PrepManual { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? ExpirationDate { get; set; }
        public AllergenTypes Allergen { get; set; }
        public int Id { get; set; }
    }
}
