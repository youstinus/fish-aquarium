using System;

namespace Zuvytes.Models
{
    public partial class Supplement
    {
        public string Name { get; set; }
        public double? Mass { get; set; }
        public string Manual { get; set; }
        public string FoodComposition { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public int Id { get; set; }
    }
}
