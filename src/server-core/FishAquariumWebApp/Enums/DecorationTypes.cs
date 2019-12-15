using System.ComponentModel.DataAnnotations;

namespace FishAquariumWebApp.Enums
{
    public enum DecorationTypes
    {
        [Display(Name = "Soil")]
        Soil,
        [Display(Name = "Rubble")]
        Rubble,
        [Display(Name = "Shell")]
        Shell,
        [Display(Name = "Coral")]
        Coral,
        [Display(Name = "Living Creature")]
        LivingCreature
    }
}
