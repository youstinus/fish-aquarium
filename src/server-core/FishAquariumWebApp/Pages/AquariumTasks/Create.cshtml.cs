using System.Collections.Generic;
using System.Threading.Tasks;
using FishAquariumWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FishAquariumWebApp.Pages.AquariumTasks
{
    public class CreateModel : PageModel
    {
        private readonly FishAquariumWebApp.Configurations.FishAquariumContext _context;

        public IList<SelectListItem> Options { get; set; }


        public CreateModel(FishAquariumWebApp.Configurations.FishAquariumContext context)
        {
            _context = context;
        }
 
        public IActionResult OnGet()
        { 

            Options = (from users in _context.AquariumUser
                       join tasks in _context.AquariumTask on users.Id equals tasks.FkAquariumUser into usersTasks

                       select new SelectListItem
                       {
                          id = users.Id,
                          name = users.FirstName

                       }).ToList();
            return Page();
        }

        [BindProperty]
        public AquariumTask AquariumTask { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.AquariumTask.Add(AquariumTask);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
    public class SelectListItem
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}