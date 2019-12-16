using System;
using FishAquariumWebApp.Enums;
using System.ComponentModel.DataAnnotations;

namespace FishAquariumWebApp.Models
{
    public class Fish
    {
        [Required]
        public string Species { get; set; }
        [Required]
        public double? Mass { get; set; }
        [Required]
        public double? Size { get; set; }
        [Required]
        public string Origin { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public int? LifeExpectancy { get; set; }
        [Required]
        public string Description { get; set; }
        public FishGenderTypes Gender { get; set; }
        public int Id { get; set; }
        public int? FkAquarium { get; set; }
    }
}
