using System;
using System.Collections.Generic;

namespace test2.Models
{
    public partial class AquariumEquipment
    {
        public int FkAquarium { get; set; }
        public int FkEquipment { get; set; }
    }
}
