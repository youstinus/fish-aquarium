using System;
using System.Collections.Generic;

namespace test2.Models
{
    public partial class Fish
    {
        public string Species { get; set; }
        public double? Mass { get; set; }
        public double? Size { get; set; }
        public string Origin { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public int? LifeExpectancy { get; set; }
        public string Description { get; set; }
        public int? Gender { get; set; }
        public int Id { get; set; }
        public int? FkAquarium { get; set; }
    }
}
