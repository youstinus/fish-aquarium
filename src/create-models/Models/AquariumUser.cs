﻿using System;
using System.Collections.Generic;

namespace test2.Models
{
    public partial class AquariumUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Code { get; set; }
        public int? Type { get; set; }
        public int Id { get; set; }
    }
}
