﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFuture.Domain.Entites.DTOs
{
    public class RegisterLogin
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string ConiformPassword { get; set; }
    }
}
