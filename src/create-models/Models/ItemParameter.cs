using System;
using System.Collections.Generic;

namespace test2.Models
{
    public partial class ItemParameter
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public int? Type { get; set; }
        public int Id { get; set; }
        public int? FkFish { get; set; }
        public int? FkAquarium { get; set; }
    }
}
