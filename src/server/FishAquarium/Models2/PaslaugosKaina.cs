using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Zuvytes.Models2
{
    public class PaslaugosKaina
    {
        public int fk_paslauga { get; set; }
        [DisplayName("Galioja nuo")]
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime galiojaNuo { get; set; }
        [DisplayName("Galioja iki")]
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime galiojaIki { get; set; }
        [DisplayName("Kaina")]
        [Required]
        public decimal kaina { get; set; }

    }
}