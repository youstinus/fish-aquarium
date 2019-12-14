using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FishAquariumWebApp.Configurations;
using FishAquariumWebApp.Models;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FishAquariumWebApp.Pages.AquariumUsers
{
    public class IndexModel : PageModel
    {
        private readonly FishAquariumWebApp.Configurations.FishAquariumContext _context;


        public IndexModel(FishAquariumWebApp.Configurations.FishAquariumContext context)
        {
            _context = context;
        }

        //public IList<AquariumUser> AquariumUsers { get; set; }
        public IList<AquariumUserTasks> AquariumUsers { get; set; }

        public int filter { get; set; }
        private string level { get; set; }

        public async Task OnGetAsync(string filter)
        {
            int tasksCount = await _context.AquariumTask.CountAsync();
            int userCount = await _context.AquariumUser.CountAsync();
            int filt = tasksCount / userCount;


            AquariumUsers = (from users in _context.AquariumUser
                     join tasks in _context.AquariumTask on users.Id equals tasks.FkAquariumUser into usersTasks

                     select new AquariumUserTasks
                     {
                        Id = users.Id,
                        FirstName = users.FirstName,
                        LastName = users.LastName,
                        BirthDate = users.BirthDate,
                        RegistrationDate = users.RegistrationDate,
                        Email = users.Email,
                        Code = users.Code,
                        Type = users.Type,
                        TaskCount = usersTasks.Count()

           }).ToList();
     
            switch (filter)
            {
                case "1":
                    AquariumUsers = AquariumUsers.Where(x => x.TaskCount > ( filt * 2 / 3)).ToList();
                    break;
                case "2":
                    AquariumUsers = AquariumUsers.Where(x => x.TaskCount > (filt /  3) && x.TaskCount <= (filt * 2 / 3)).ToList();
                    break;
                case "3":
                    AquariumUsers = AquariumUsers.Where(x => x.TaskCount <= (filt / 3)).ToList();
                    break;
                default:  
                    break;
            }
        }

    }

    public class AquariumUserTasks
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public string Email { get; set; }
        public string Code { get; set; }
        public int Type { get; set; }
        public int TaskCount { get; set; }
        public int Id { get; set; }
    }
}
