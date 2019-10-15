using System.ComponentModel;

namespace FishAquarium.ViewModels2
{
    public class PaslauguAtaskaitaViewModel
    {
        [DisplayName("ID")]
        public int id { get; set; }
        [DisplayName("Pavadinimas")]
        public string pavadinimas { get; set; }
        [DisplayName("Kiekis")]
        public int kiekis { get; set; }
        [DisplayName("Suma")]
        public decimal suma { get; set; }
    }
}