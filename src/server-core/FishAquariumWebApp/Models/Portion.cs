using System;
using System.ComponentModel.DataAnnotations;

namespace FishAquariumWebApp.Models
{
    public class Portion
    {
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? PreparationDate { get; set; }
        public int Id { get; set; }
        public int? FkFood { get; set; }
        public int? FkSupplement { get; set; }
    }
}
