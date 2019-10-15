using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Zuvytes.ViewModels
{
    public class PslgAtaskaitaViewModel
    {
        public List<PaslauguAtaskaitaViewModel> paslaugos { get; set; }
        public int visoUzsakyta { get; set; }
        public decimal bendraSuma { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",ApplyFormatInEditMode = true)]
        public DateTime? nuo { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? iki { get; set; }
    }
}