﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Zuvytes.Models2
{
    public class Klientas
    {
        [DisplayName("Asmens kodas")]
        [Required]
        public string asmensKodas { get; set; }
        [DisplayName("Vardas")]
        [Required]
        public string vardas { get; set; }
        [DisplayName("Pavardė")]
        [Required]
        public string pavarde { get; set; }
        [DisplayName("Gimimo data")]
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime gimimoData { get; set; }
        [DisplayName("Telefonas")]
        [Required]
        public string telefonas { get; set; }
        [DisplayName("Elektroninis paštas")]
        [EmailAddress]
        [Required]
        public string epastas { get; set; }
    }
}