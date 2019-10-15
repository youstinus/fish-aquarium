using System.ComponentModel;

namespace FishAquarium.Models2
{
    public class Modelis
    {
        [DisplayName("ID")]
        public int id { get; set; }
        [DisplayName("Pavadinimas")]
        public string pavadinimas { get; set; }
        //Markė
        [DisplayName("Markė")]
        public virtual Marke marke { get; set; }

    }
}