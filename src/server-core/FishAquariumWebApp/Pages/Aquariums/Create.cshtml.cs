using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FishAquariumWebApp.Models;

namespace FishAquariumWebApp.Pages.Aquariums
{
    public class CreateModel : PageModel
    {
        private readonly Configurations.FishAquariumContext _context;

        public CreateModel(Configurations.FishAquariumContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            if (!IsAdmin())
            {
                return RedirectToPage("Index");
            }

            return Page();
        }

        [BindProperty]
        public Aquarium Aquarium { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Aquarium.Add(Aquarium);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

        public bool IsAdmin()
        {
            return true;
        }
    }
}