using System.Threading.Tasks;
using FishAquariumWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FishAquariumWebApp.Pages.AquariumTasks
{
    public class DeleteModel : PageModel
    {
        private readonly FishAquariumWebApp.Configurations.FishAquariumContext _context;

        public DeleteModel(FishAquariumWebApp.Configurations.FishAquariumContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AquariumTask AquariumTask { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AquariumTask = await _context.AquariumTask.FindAsync(id);

            if (AquariumTask != null)
            {
                _context.AquariumTask.Remove(AquariumTask);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
