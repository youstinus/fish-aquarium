using System.Collections.Generic;
using Zuvytes.Models;

namespace Zuvytes.ViewModels
{
    public class PaslaugaEditViewModel
    {
        //Paslauga
        public Paslauga paslauga { get; set; }
        //Paslaugos kainų sąrašas
        public List<PaslaugosKainaViewModel> paslaugosKainos { get; set; }
    }
}