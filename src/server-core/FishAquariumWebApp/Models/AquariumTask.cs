using System;
using FishAquariumWebApp.Enums;
using System.ComponentModel.DataAnnotations;

namespace FishAquariumWebApp.Models
{
    public class AquariumTask
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public double? Duration { get; set; }
        [Required]
        public DateTime? StartTime { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public TaskStateTypes State { get; set; }
        public int Id { get; set; }
        [Required]
        public int? FkAquarium { get; set; }
        [Required]
        public int? FkAquariumUser { get; set; }
    }
}
