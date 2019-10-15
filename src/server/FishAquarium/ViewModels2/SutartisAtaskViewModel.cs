using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FishAquarium.ViewModels2
{
    public class SutartisAtaskViewModel
    {
        public List<SAtaskaitaViewModel> sutartys { get; set; }
        public decimal visoSumaSutartciu { get; set; }
        public decimal visoSumaPaslauga { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ?nuo { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ?iki { get; set; }
    }
}