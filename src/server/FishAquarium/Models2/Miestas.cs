using System.Collections.Generic;

namespace FishAquarium.Models2
{
    public class Miestas
    {
        public int id { get; set; }
        public string pavadinimas { get; set; }

        public virtual ICollection<Aikstele> Aiksteles { get; set; }
    }
}