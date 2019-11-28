using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FishAquariumWebApp.Models;

namespace FishAquariumWebApp.Pages
{
    public class LoginModel : PageModel
    {
        public string Msg;

        private readonly FishAquariumWebApp.Configurations.FishAquariumContext _context;

        [BindProperty]

        public AquariumUser AquariumUser { get; set; }

        public LoginModel(FishAquariumWebApp.Configurations.FishAquariumContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
        }

        public async System.Threading.Tasks.Task<IActionResult> OnPostAsync(string mail, string password)
        {
            var enc = CipherService.Encrypt(password);
            AquariumUser = await _context.AquariumUser.FirstOrDefaultAsync(m => m.Email == mail && m.Password == enc);
            string a = CipherService.Encrypt(password);
            if (AquariumUser != null)
            {
                HttpContext.Session.SetString("username", AquariumUser.FirstName + " " + AquariumUser.LastName);
                HttpContext.Session.SetString("role", AquariumUser.Type == 1 ? UserTypes.Admin.ToString() :
                                                       AquariumUser.Type == 2 ? UserTypes.User.ToString() : UserTypes.Guest.ToString());
                return RedirectToPage("Index");
            }
            else
            {
                Msg = "Invalid";
                return Page();
            }
        }
    }
}
