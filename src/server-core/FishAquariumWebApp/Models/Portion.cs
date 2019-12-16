using System;
using System.ComponentModel.DataAnnotations;

namespace FishAquariumWebApp.Models
{
    public class Portion
    {
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? PreparationDate { get; set; }
        public int Id { get; set; }
        [Required]
        public int? FkFood { get; set; }
        [Required]
        public int? FkSupplement { get; set; }
    }
}
