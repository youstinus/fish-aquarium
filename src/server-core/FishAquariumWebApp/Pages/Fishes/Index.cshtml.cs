using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FishAquariumWebApp.Models;
using Microsoft.AspNetCore.Http;

namespace FishAquariumWebApp.Pages.Fishes
{
    public class IndexModel : PageModel
    {
        private readonly FishAquariumWebApp.Configurations.FishAquariumContext _context;

        public IndexModel(FishAquariumWebApp.Configurations.FishAquariumContext context)
        {
            _context = context;
        }

        public IList<Fish> Fishes { get;set; }

        public async Task OnGetAsync()
        {
            Fishes = await _context.Fish.ToListAsync();
        }
        
        public bool IsAdmin()
        {
            return HttpContext.Session.GetString("role") == UserTypes.Admin.ToString();
        }
    }
}
