﻿using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class LanguageNames
    {
        public long LanguageId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }

        public virtual Languages Language { get; set; }
        public virtual Languages LocalLanguage { get; set; }
    }
}
