using System.Threading.Tasks;
using FishAquariumWebApp.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FishAquariumWebApp.Models;
using Microsoft.AspNetCore.Http;

namespace FishAquariumWebApp.Pages.Aquariums
{
    public class DeleteModel : PageModel
    {
        private readonly FishAquariumWebApp.Configurations.FishAquariumContext _context;

        public DeleteModel(FishAquariumWebApp.Configurations.FishAquariumContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Aquarium Aquarium { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (!IsAdmin())
            {
                return RedirectToPage("Index");
            }

            if (id == null)
            {
                return NotFound();
            }

            Aquarium = await _context.Aquarium.FirstOrDefaultAsync(m => m.Id == id);

            if (Aquarium == null)
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

            Aquarium = await _context.Aquarium.FindAsync(id);

            if (Aquarium != null)
            {
                _context.Aquarium.Remove(Aquarium);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }

        public bool IsAdmin()
        {
            return HttpContext.Session.GetString("role") == UserTypes.Admin.ToString();
        }
    }
}
