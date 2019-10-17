using System;
using System.Collections.Generic;

namespace test2.Models
{
    public partial class AquariumTask
    {
        public string Name { get; set; }
        public double? Duration { get; set; }
        public DateTime? StartTime { get; set; }
        public string Description { get; set; }
        public int? State { get; set; }
        public int Id { get; set; }
        public int? FkAquarium { get; set; }
        public int? FkAquariumUser { get; set; }
    }
}
