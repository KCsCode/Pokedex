﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokedexAPI.DTO
{
    public class TrainerRequestDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }
        public string ContactNumber { get; set; }
    }
}
