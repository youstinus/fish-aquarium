using System.ComponentModel;

namespace Zuvytes.Models
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