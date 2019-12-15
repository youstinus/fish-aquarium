using System.ComponentModel.DataAnnotations;

namespace FishAquariumWebApp.Enums
{
    public enum UserTypes
    {
        [Display(Name = "Admin")]
        Admin,
        [Display(Name = "User")]
        User,
        [Display(Name = "Guest")]
        Guest
    }
}
