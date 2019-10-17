using System;
using System.Collections.Generic;

namespace test2.Models
{
    public partial class Portion
    {
        public DateTime? PreparationDate { get; set; }
        public int Id { get; set; }
        public int? FkFood { get; set; }
        public int? FkSupplement { get; set; }
    }
}
