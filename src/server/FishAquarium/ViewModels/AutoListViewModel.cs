﻿using System.ComponentModel;

namespace Zuvytes.ViewModels
{
    public class AutoListViewModel
    {
        [DisplayName("ID")]
        public int id { get; set; }
        [DisplayName("Valstybinis nr.")]
        public string valstybinisNr { get; set; }
        [DisplayName("Būsena")]
        public string busena { get; set; }
        [DisplayName("Modelis")]
        public string modelis { get; set; }
        [DisplayName("Markė")]
        public string marke { get; set; }
    }
}