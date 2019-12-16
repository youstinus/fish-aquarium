using FishAquariumWebApp.Enums;
using System.ComponentModel.DataAnnotations;

namespace FishAquariumWebApp.Models
{
    public class ItemParameter
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Value { get; set; }
        [Required]
        public ParameterTypes Type { get; set; }
    
        public int Id { get; set; }
        public int? FkFish { get; set; }
        public int? FkAquarium { get; set; }
    }
}
