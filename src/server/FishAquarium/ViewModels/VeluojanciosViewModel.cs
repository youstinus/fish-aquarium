using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Zuvytes.ViewModels
{
    public class VeluojanciosViewModel
    {
        public List<VeluojanciosSutartysViewModel> sutartys { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ?nuo { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ?iki { get; set; }
    }
}