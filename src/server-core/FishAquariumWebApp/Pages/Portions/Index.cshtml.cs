using System.Collections.Generic;
using System.Threading.Tasks;
using FishAquariumWebApp.Enums;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FishAquariumWebApp.Models;
using Microsoft.AspNetCore.Http;

namespace FishAquariumWebApp.Pages.Portions
{
    public class IndexModel : PageModel
    {
        private readonly FishAquariumWebApp.Configurations.FishAquariumContext _context;

        public IndexModel(FishAquariumWebApp.Configurations.FishAquariumContext context)
        {
            _context = context;
        }

        public IList<Portion> Portions { get;set; }
        public IList<Food> Foods { get; set; }
        public IList<Supplement> Supplements { get; set; }

        public async Task OnGetAsync()
        {
            Portions = await _context.Portion.ToListAsync();
            Foods = await _context.Food.ToListAsync();
            Supplements = await _context.Supplement.ToListAsync();
        }

        public bool IsUserOrAdmin()
        {
            return HttpContext.Session.GetString("role") == UserTypes.User.ToString() || HttpContext.Session.GetString("role") == UserTypes.Admin.ToString();
        }
    }
}
