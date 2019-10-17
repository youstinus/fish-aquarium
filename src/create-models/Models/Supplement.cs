using System;
using System.Collections.Generic;

namespace test2.Models
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
