using System;

namespace Zuvytes.Models2
{
    public class NuomosTarifas
    {
        public int id { get; set; }
        public DateTime galiojaNuo { get; set; }
        public DateTime galiojaIki { get; set; }
        public double tarifas { get; set; }
    }
}