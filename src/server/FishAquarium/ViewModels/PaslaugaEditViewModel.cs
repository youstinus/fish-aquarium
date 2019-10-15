using System.Collections.Generic;
using Zuvytes.Models2;

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