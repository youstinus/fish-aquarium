namespace FishAquarium.Models
{
    public partial class Parameters
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public int? Type { get; set; }
        public int Id { get; set; }
        public int? FkFish { get; set; }
        public int? FkAquarium { get; set; }
    }
}
