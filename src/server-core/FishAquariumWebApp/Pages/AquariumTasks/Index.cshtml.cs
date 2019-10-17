using System.Collections.Generic;
using System.Threading.Tasks;
using FishAquariumWebApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FishAquariumWebApp.Pages.AquariumTasks
{
    public class IndexModel : PageModel
    {
        private readonly FishAquariumWebApp.Configurations.FishAquariumContext _context;

        public IndexModel(FishAquariumWebApp.Configurations.FishAquariumContext context)
        {
            _context = context;
        }

        public IList<AquariumTask> AquariumTasks { get;set; }

        public async Task OnGetAsync()
        {
            AquariumTasks = await _context.AquariumTask.ToListAsync();
        }
    }
}
