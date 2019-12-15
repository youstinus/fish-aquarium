using FishAquariumWebApp.Enums;

namespace FishAquariumWebApp.Models
{
    public class Decoration
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public double? Mass { get; set; }
        public string Description { get; set; }
        public string Material { get; set; }
        public DecorationTypes Type { get; set; }
        public int Id { get; set; }
    }
}
