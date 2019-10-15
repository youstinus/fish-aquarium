namespace FishAquarium.Models
{
    public partial class AquariumInsideHasDecoration
    {
        public int FkDecoration { get; set; }
        public int FkAquarium { get; set; }
    }
}
