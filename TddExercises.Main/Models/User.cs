﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddExercises.Main.Models
{
    public class User
    {
        public string Email { get; set; }
        public bool IsActive { get; internal set; }
        public string Password { get; set; }
    }
}
