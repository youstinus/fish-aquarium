using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FishAquariumWebApp.Configurations;
using FishAquariumWebApp.Models;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using Microsoft.AspNetCore.DataProtection;

namespace FishAquariumWebApp.Pages.AquariumUsers
{
    public class CreateModel : PageModel
    {

        private readonly FishAquariumWebApp.Configurations.FishAquariumContext _context;

        private readonly IDataProtectionProvider _dataProtectionProvider;
        private const string Key = "my-very-long-key-of-no-exact-size"; 
        
        public CreateModel(FishAquariumWebApp.Configurations.FishAquariumContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public AquariumUser AquariumUser { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            AquariumUser.Password = CipherService.Encrypt(AquariumUser.Password);

            _context.AquariumUser.Add(AquariumUser);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

    }
}