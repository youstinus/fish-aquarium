using System.ComponentModel;

namespace FishAquarium.ViewModels2
{
    public class ModelisViewModel
    {
        [DisplayName("ID")]
        public int id { get; set; }
        [DisplayName("Pavadinimas")]
        public string pavadinimas { get; set; }
        [DisplayName("Markė")]
        public string marke { get; set; }

    }
}