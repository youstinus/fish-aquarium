using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FishAquariumWebApp.Models;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FishAquariumWebApp.Pages.Fishes
{
    public class CreateModel : PageModel
    {
        private readonly FishAquariumWebApp.Configurations.FishAquariumContext _context;

        public CreateModel(FishAquariumWebApp.Configurations.FishAquariumContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGet()
        {
            if (!IsAdmin())
            {
                return RedirectToPage("Index");
            }

            Aquariums = await _context.Aquarium.ToListAsync();
            return Page();
        }

        [BindProperty]
        public Fish Fish { get; set; }

        public List<Aquarium> Aquariums { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Fish.Add(Fish);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

        public IEnumerable<SelectListItem> GetAquariumSelectListItems()
        {
            return Aquariums.Select(x => new SelectListItem(x.Id.ToString(), x.Id.ToString()));
        }

        public bool IsAdmin()
        {
            return HttpContext.Session.GetString("role") == UserTypes.Admin.ToString();
        }
    }
}