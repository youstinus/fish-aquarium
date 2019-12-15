using FishAquariumWebApp.Enums;

namespace FishAquariumWebApp.Models
{
    public class Equipment
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public EquipmentTypes Type { get; set; }
        public int Id { get; set; }
    }
}
