using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FishAquariumWebApp.Configurations;
using FishAquariumWebApp.Models;

namespace FishAquariumWebApp.Pages.AquariumUsers
{
    public class EditModel : PageModel
    {
        private readonly FishAquariumWebApp.Configurations.FishAquariumContext _context;

        public EditModel(FishAquariumWebApp.Configurations.FishAquariumContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(AquariumUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AquariumUserExists(AquariumUser.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AquariumUserExists(int id)
        {
            return _context.AquariumUser.Any(e => e.Id == id);
        }
    }
}
