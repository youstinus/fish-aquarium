using System.ComponentModel.DataAnnotations;

namespace FishAquariumWebApp.Enums
{
    public enum EquipmentTypes
    {
        [Display(Name = "Filter")]
        Filter,
        [Display(Name = "Illuminator")]
        Illuminator,
        [Display(Name = "Bubbler")]
        Bubbler,
        [Display(Name = "Thermostat")]
        Thermostat,
        [Display(Name = "Heater")]
        Heater
    }
}
