using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FishAquariumWebApp.Models;

namespace FishAquariumWebApp.Pages.Aquariums
{
    public class SearchModel : PageModel
    {
        private readonly Configurations.FishAquariumContext _context;

        public SearchModel(Configurations.FishAquariumContext context)
        {
            _context = context;
        }

        public string SearchString { get; set; }
        public IList<Aquarium> Aquariums { get; set; }
        public IList<Fish> Fishes { get; set; }

        public async Task OnGetAsync(string searchString)
        {
            SearchString = searchString;
            Aquariums = await _context.Aquarium.ToListAsync();
            Fishes = await _context.Fish.ToListAsync();

            if (!string.IsNullOrEmpty(searchString))
            {
                Fishes = Fishes.Where(s => s.Description.ToLower().Contains(searchString.ToLower())
                                           || s.Origin.ToLower().Contains(searchString.ToLower())
                                           || s.Species.ToLower().Contains(searchString.ToLower())).ToList();

            }
            else
            {
                SearchString = "";
            }
        }
    }
}
