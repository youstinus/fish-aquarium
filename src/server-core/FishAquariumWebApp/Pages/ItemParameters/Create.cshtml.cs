using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FishAquariumWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FishAquariumWebApp.Pages.ItemParameters
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
            Fishes = (await _context.Fish.ToListAsync()).Select(x => new SelectListItem(x.Species.ToString(), x.Id.ToString()));
            Aquariums = (await _context.Aquarium.ToListAsync()).Select(x => new SelectListItem(x.Id.ToString(), x.Id.ToString()));
            return Page();
        }

        [BindProperty]
        public ItemParameter ItemParameter { get; set; }
        public IEnumerable<SelectListItem> Fishes { get; set; }
        public IEnumerable<SelectListItem> Aquariums { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ItemParameter.Add(ItemParameter);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}