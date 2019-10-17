using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FishAquariumWebApp.Models;

namespace FishAquariumWebApp.Pages.Decorations
{
    public class IndexModel : PageModel
    {
        private readonly FishAquariumWebApp.Configurations.FishAquariumContext _context;

        public IndexModel(FishAquariumWebApp.Configurations.FishAquariumContext context)
        {
            _context = context;
        }

        public IList<Decoration> Decorations { get;set; }

        public async Task OnGetAsync()
        {
            Decorations = await _context.Decoration.ToListAsync();
        }
    }
}
