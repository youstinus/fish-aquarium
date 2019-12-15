using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FishAquariumWebApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FishAquariumWebApp.Pages.Portions
{
    public class CreateModel : PageModel
    {
        private readonly FishAquariumWebApp.Configurations.FishAquariumContext _context;

        public CreateModel(FishAquariumWebApp.Configurations.FishAquariumContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGet()
        {
            Foods = (await _context.Food.ToListAsync()).Select(x => new SelectListItem(x.Name, x.Id.ToString()));
            Supplements = (await _context.Supplement.ToListAsync()).Select(x => new SelectListItem(x.Name, x.Id.ToString()));

            return Page();
        }

        [BindProperty]
        public Portion Portion { get; set; }
        public IEnumerable<SelectListItem> Foods { get; set; }
        public IEnumerable<SelectListItem> Supplements { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Portion.Add(Portion);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}