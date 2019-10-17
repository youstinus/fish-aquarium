using System;

namespace FishAquariumWebApp.Models
{
    public class Portion
    {
        public DateTime? PreparationDate { get; set; }
        public int Id { get; set; }
        public int? FkFood { get; set; }
        public int? FkSupplement { get; set; }
    }
}
