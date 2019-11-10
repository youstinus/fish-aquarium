using System.ComponentModel.DataAnnotations;

namespace FishAquariumWebApp.Enums
{
    public enum FishGenderTypes
    {
        [Display(Name = "Male")]
        Male,
        [Display(Name = "Female")]
        Female,
        [Display(Name = "Hermaphrodite")]
        Hermaphrodite
    }
}
