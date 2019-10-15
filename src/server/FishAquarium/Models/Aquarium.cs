namespace FishAquarium.Models
{
    public partial class Aquarium
    {
        public double? Capacity { get; set; }
        public double? Mass { get; set; }
        public double? Length { get; set; }
        public double? Width { get; set; }
        public double? Heigth { get; set; }
        public int? GlassThickness { get; set; }
        public int Id { get; set; }
        public int? FkPortion { get; set; }
    }
}
