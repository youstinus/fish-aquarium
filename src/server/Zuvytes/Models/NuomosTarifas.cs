using System;

namespace Zuvytes.Models
{
    public class NuomosTarifas
    {
        public int id { get; set; }
        public DateTime galiojaNuo { get; set; }
        public DateTime galiojaIki { get; set; }
        public double tarifas { get; set; }
    }
}