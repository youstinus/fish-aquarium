using System.ComponentModel;

namespace Zuvytes.ViewModels
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