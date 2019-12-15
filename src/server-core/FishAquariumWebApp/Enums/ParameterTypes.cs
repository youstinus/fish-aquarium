using System.ComponentModel.DataAnnotations;

namespace FishAquariumWebApp.Enums
{
    public enum ParameterTypes
    {
        [Display(Name = "Temperature")]
        Temperature,
        [Display(Name = "O2Concentration")]
        O2Concentration,
        [Display(Name = "Ph")]
        Ph,
        [Display(Name = "WaterColor")]
        WaterColor
    }
}
