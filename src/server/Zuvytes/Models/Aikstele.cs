namespace Zuvytes.Models
{
    public class Aikstele
    {
        public int id { get; set; }
        public string pavadinimas { get; set; }
        public string adresas { get; set; }
        public int fk_miestas { get; set; }
    }
}