using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FishAquariumWebApp.Pages.Parameters
{
    public class EditModel : PageModel
    {
        private readonly FishAquariumWebApp.Configurations.FishAquariumContext _context;

        public EditModel(FishAquariumWebApp.Configurations.FishAquariumContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.Parameters Parameters { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Parameters = await _context.Parameters.FirstOrDefaultAsync(m => m.Id == id);

            if (Parameters == null)
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

            _context.Attach(Parameters).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ParametersExists(Parameters.Id))
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

        private bool ParametersExists(int id)
        {
            return _context.Parameters.Any(e => e.Id == id);
        }
    }
}
