using System.Threading.Tasks;
using FishAquariumWebApp.Enums;
using FishAquariumWebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FishAquariumWebApp.Pages.AquariumTasks
{
    public class DetailsModel : PageModel
    {
        private readonly FishAquariumWebApp.Configurations.FishAquariumContext _context;

        public DetailsModel(FishAquariumWebApp.Configurations.FishAquariumContext context)
        {
            _context = context;
        }

        public AquariumTask AquariumTask { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AquariumTask = await _context.AquariumTask.FirstOrDefaultAsync(m => m.Id == id);

            if (AquariumTask == null)
            {
                return NotFound();
            }
            return Page();
        }

        public bool IsUserOrAdmin()
        {
            return HttpContext.Session.GetString("role") == UserTypes.User.ToString() || HttpContext.Session.GetString("role") == UserTypes.Admin.ToString();
        }
    }
}
