using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FishAquariumWebApp.Models;

namespace FishAquariumWebApp.Pages.Aquariums
{
    public class DetailsModel : PageModel
    {
        private readonly FishAquariumWebApp.Configurations.FishAquariumContext _context;

        public DetailsModel(FishAquariumWebApp.Configurations.FishAquariumContext context)
        {
            _context = context;
        }

        public Aquarium Aquarium { get; set; }
        public List<Fish> Fishes { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Aquarium = await _context.Aquarium.FirstOrDefaultAsync(m => m.Id == id);
            Fishes = await _context.Fish.Where(x => x.FkAquarium == id).ToListAsync();

            if (Aquarium == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
