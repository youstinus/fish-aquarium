using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FishAquarium.ViewModels2
{
    public class VeluojanciosSutartysViewModel
    {
        [DisplayName("Sutartis")]
        public int nr { get; set; }

        public DateTime sutartiesData { get; set; }
        [DisplayName("Klientas")]
        public string klientas { get; set; }
        [DisplayName("Planuota grąžinti")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime planuojamaGrData { get; set; }
        [DisplayName("Grąžintina")]
        public string faktineGrData { get; set; }
    }
}