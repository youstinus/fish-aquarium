using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Zuvytes.Models2
{
    public class Marke
    {
        [DisplayName("ID")]
        public int id { get; set; }
        [DisplayName("Pavadinimas")]
        [Required]
        public string pavadinimas { get; set; }
    }
}