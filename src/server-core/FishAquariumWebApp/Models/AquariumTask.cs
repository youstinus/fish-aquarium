using System;
using FishAquariumWebApp.Enums;

namespace FishAquariumWebApp.Models
{
    public class AquariumTask
    {
        public string Name { get; set; }
        public double? Duration { get; set; }
        public DateTime? StartTime { get; set; }
        public string Description { get; set; }
        public TaskStateTypes State { get; set; }
        public int Id { get; set; }
        public int? FkAquarium { get; set; }
        public int? FkAquariumUser { get; set; }
    }
}
