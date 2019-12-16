using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FishAquariumWebApp.Models
{
    public class Aquarium
    {
        [Required]
        public double? Capacity { get; set; }
        [Required]
        public double? Mass { get; set; }
        [Required]
        public double? Length { get; set; }
        public double? Width { get; set; }
        public double? Heigth { get; set; }
        public int? GlassThickness { get; set; }
        public int Id { get; set; }
        public int? FkPortion { get; set; }
    }
}
