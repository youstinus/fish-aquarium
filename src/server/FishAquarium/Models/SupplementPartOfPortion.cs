namespace FishAquarium.Models
{
    public partial class SupplementPartOfPortion
    {
        public int FkPortion { get; set; }
        public int FkSupplement { get; set; }
    }
}
