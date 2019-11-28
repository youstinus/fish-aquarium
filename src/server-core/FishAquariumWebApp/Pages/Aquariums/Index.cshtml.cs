using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FishAquariumWebApp.Models;
using Microsoft.AspNetCore.Http;

namespace FishAquariumWebApp.Pages.Aquariums
{
    public class IndexModel : PageModel
    {
        private readonly FishAquariumWebApp.Configurations.FishAquariumContext _context;

        public IndexModel(FishAquariumWebApp.Configurations.FishAquariumContext context)
        {
            _context = context;
        }

        public IList<Aquarium> Aquariums { get;set; }

        public async Task OnGetAsync()
        {
            Aquariums = await _context.Aquarium.ToListAsync();
        }

        public bool IsAdmin()
        {
            return HttpContext.Session.GetString("role") == UserTypes.Admin.ToString();
        }
    }
}
