using System.Linq;
using System.Threading.Tasks;
using FishAquariumWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FishAquariumWebApp.Pages.AquariumTasks
{
    public class EditModel : PageModel
    {
        private readonly FishAquariumWebApp.Configurations.FishAquariumContext _context;
        public List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> UserOptions { get; set; }
        public List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> AquariumOptions { get; set; }
        public EditModel(FishAquariumWebApp.Configurations.FishAquariumContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AquariumTask AquariumTask { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            UserOptions = _context.AquariumUser.Select(a => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
            {
                Value = a.Id.ToString(),
                Text = a.FirstName
            }).ToList();

            AquariumOptions = _context.Aquarium.Select(a => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
            {
                Value = a.Id.ToString(),
                Text = a.Id.ToString()
            }).ToList();

            if (id == null)
            {
                return NotFound();
            }

            AquariumTask = await _context.AquariumTask.FirstOrDefaultAsync(m => m.Id == id);

            if (AquariumTask == null)
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

            _context.Attach(AquariumTask).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TasksExists(AquariumTask.Id))
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

        private bool TasksExists(int id)
        {
            return _context.AquariumTask.Any(e => e.Id == id);
        }
    }
}
