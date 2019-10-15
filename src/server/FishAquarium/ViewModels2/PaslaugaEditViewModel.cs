using System.Collections.Generic;
using FishAquarium.Models2;

namespace FishAquarium.ViewModels2
{
    public class PaslaugaEditViewModel
    {
        //Paslauga
        public Paslauga paslauga { get; set; }
        //Paslaugos kainų sąrašas
        public List<PaslaugosKainaViewModel> paslaugosKainos { get; set; }
    }
}