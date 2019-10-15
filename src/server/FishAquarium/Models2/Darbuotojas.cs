using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Zuvytes.Models2
{
    public class Darbuotojas
    {
        [DisplayName("Tabelio nr.")]
        [MaxLength(10)]
        [Required]
        public string tabelis { get; set; }
        [DisplayName("Vardas")]
        [MaxLength(20)]
        [Required]
        public string vardas { get; set; }
        [DisplayName("Pavardė")]
        [MaxLength(20)]
        [Required]
        public string pavarde { get; set; }
    }
}