using System.ComponentModel.DataAnnotations;

namespace FishAquariumWebApp.Enums
{
    public enum TaskStateTypes
    {
        [Display(Name = "Active")]
        Active,
        [Display(Name = "Canceled")]
        Canceled,
        [Display(Name = "Completed")]
        Completed
    }
}
