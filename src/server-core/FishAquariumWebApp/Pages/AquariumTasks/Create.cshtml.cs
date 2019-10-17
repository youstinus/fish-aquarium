using System.Threading.Tasks;
using FishAquariumWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FishAquariumWebApp.Pages.AquariumTasks
{
    public class CreateModel : PageModel
    {
        private readonly FishAquariumWebApp.Configurations.FishAquariumContext _context;

        public CreateModel(FishAquariumWebApp.Configurations.FishAquariumContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public AquariumTask AquariumTask { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.AquariumTask.Add(AquariumTask);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}