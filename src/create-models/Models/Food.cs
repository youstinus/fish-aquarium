﻿using System;
using System.Collections.Generic;

namespace test2.Models
{
    public partial class Food
    {
        public string Name { get; set; }
        public double? Mass { get; set; }
        public double? Calories { get; set; }
        public double? Carbs { get; set; }
        public double? Proten { get; set; }
        public double? Fat { get; set; }
        public string PrepManual { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public int? Allergen { get; set; }
        public int Id { get; set; }
    }
}
