using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FishAquariumWebApp.Enums;
using FishAquariumWebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FishAquariumWebApp.Pages.ItemParameters
{
    public class IndexModel : PageModel
    {
        private readonly FishAquariumWebApp.Configurations.FishAquariumContext _context;

        public IndexModel(FishAquariumWebApp.Configurations.FishAquariumContext context)
        {
            _context = context;
        }

        public IList<ItemParameter> ItemParameters { get;set; }
        public List<Fish> Fishes { get; set; }
        public List<Aquarium> Aquariums { get; set; }

        public async Task OnGetAsync()
        {
            ItemParameters = await _context.ItemParameter.ToListAsync();
            Fishes = (await _context.Fish.ToListAsync());
            Aquariums = (await _context.Aquarium.ToListAsync());
        }

        public bool IsUserOrAdmin()
        {
            return HttpContext.Session.GetString("role") == UserTypes.User.ToString() || HttpContext.Session.GetString("role") == UserTypes.Admin.ToString();
        }
    }
}
