using System.ComponentModel.DataAnnotations;

namespace FishAquariumWebApp.Enums
{
    public enum AllergenTypes
    {
        [Display(Name = "Lactose")]
        Lactose,
        [Display(Name = "Gluten")]
        Gluten,
        [Display(Name = "Nuts")]
        Nuts
    }
}
