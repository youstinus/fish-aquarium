using System.Collections.Generic;
using System.Threading.Tasks;
using FishAquariumWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace FishAquariumWebApp.Pages.AquariumTasks
{
    public class CreateModel : PageModel
    {
        private readonly FishAquariumWebApp.Configurations.FishAquariumContext _context;
        public List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> UserOptions { get; set; }
        public List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> AquariumOptions { get; set; }
        public CreateModel(FishAquariumWebApp.Configurations.FishAquariumContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
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