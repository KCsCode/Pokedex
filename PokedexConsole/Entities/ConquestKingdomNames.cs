﻿using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class ConquestKingdomNames
    {
        public long KingdomId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }

        public virtual ConquestKingdoms Kingdom { get; set; }
        public virtual Languages LocalLanguage { get; set; }
    }
}
