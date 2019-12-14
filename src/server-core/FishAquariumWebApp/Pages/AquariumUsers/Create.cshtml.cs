using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FishAquariumWebApp.Configurations;
using FishAquariumWebApp.Models;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using Microsoft.AspNetCore.DataProtection;
using System.Net.Mail;
using Microsoft.Extensions.Configuration;
using System.Net;

namespace FishAquariumWebApp.Pages.AquariumUsers
{
    public class CreateModel : PageModel
    {

        private readonly FishAquariumWebApp.Configurations.FishAquariumContext _context;
        
        public CreateModel(FishAquariumWebApp.Configurations.FishAquariumContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public AquariumUser AquariumUser { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            string password = GeneratePassword();
            SendEmail(AquariumUser.Email, password);

            AquariumUser.Password = CipherService.Encrypt(password);
            AquariumUser.RegistrationDate = DateTime.Now;
            AquariumUser.Type++;
            _context.AquariumUser.Add(AquariumUser);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");

        }

        private string GeneratePassword()
        {
            int length = 8;
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
            
        }

        private void SendEmail(string email, string password)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("indreee.1997@gmail.com");
                mail.To.Add(email);
                mail.Subject = "You have been added to Fish Aquarium";
                mail.Body = "<h1>Hello</h1>" +
                    "<p> You have been added to Fish Aquarium system. You can login with your email " +
                    email + " and password " + password;
                mail.IsBodyHtml = true;

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = new NetworkCredential("indreee.1997@gmail.com", "dwzgvdkixhqsxxxo");
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
            }
        }

    }
}