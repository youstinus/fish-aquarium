using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FishAquariumWebApp.Models;
using Microsoft.AspNetCore.Http;

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
                Aquariums = Aquariums.Where(s => (s.Capacity!=null && s.Capacity.ToString().Contains(searchString.ToLower()))
                                                 || (s.GlassThickness != null && s.GlassThickness.ToString().Contains(searchString.ToLower()))
                                                 || (s.Heigth != null && s.Heigth.ToString().Contains(searchString.ToLower()))
                                                 || (s.Length != null && s.Length.ToString().Contains(searchString.ToLower()))
                                                 || (s.Mass != null && s.Mass.ToString().Contains(searchString.ToLower()))
                                                 || (s.Width != null && s.Width.ToString().Contains(searchString.ToLower()))
                                                 || (Fishes.Select(x => x.FkAquarium).Contains(s.Id))).ToList();
            }
            else
            {
                SearchString = "";
            }
        }

        public bool IsAdmin()
        {
            return HttpContext.Session.GetString("role") == UserTypes.Admin.ToString();
        }
    }
}
