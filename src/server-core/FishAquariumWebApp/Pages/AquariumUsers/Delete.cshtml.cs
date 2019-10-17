using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FishAquariumWebApp.Configurations;
using FishAquariumWebApp.Models;

namespace FishAquariumWebApp.Pages.AquariumUsers
{
    public class DeleteModel : PageModel
    {
        private readonly FishAquariumWebApp.Configurations.FishAquariumContext _context;

        public DeleteModel(FishAquariumWebApp.Configurations.FishAquariumContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AquariumUser AquariumUser { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AquariumUser = await _context.AquariumUser.FirstOrDefaultAsync(m => m.Id == id);

            if (AquariumUser == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AquariumUser = await _context.AquariumUser.FindAsync(id);

            if (AquariumUser != null)
            {
                _context.AquariumUser.Remove(AquariumUser);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
