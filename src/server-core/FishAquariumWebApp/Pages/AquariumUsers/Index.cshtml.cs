using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FishAquariumWebApp.Configurations;
using FishAquariumWebApp.Models;

namespace FishAquariumWebApp.Pages.AquariumUsers
{
    public class IndexModel : PageModel
    {
        private readonly FishAquariumWebApp.Configurations.FishAquariumContext _context;

        public IndexModel(FishAquariumWebApp.Configurations.FishAquariumContext context)
        {
            _context = context;
        }

        public IList<AquariumUser> AquariumUsers { get;set; }

        public async Task OnGetAsync()
        {
            AquariumUsers = await _context.AquariumUser.ToListAsync();
        }
    }
}
