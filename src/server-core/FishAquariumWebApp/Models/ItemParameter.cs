using FishAquariumWebApp.Enums;

namespace FishAquariumWebApp.Models
{
    public class ItemParameter
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public ParameterTypes Type { get; set; }
        public int Id { get; set; }
        public int? FkFish { get; set; }
        public int? FkAquarium { get; set; }
    }
}
