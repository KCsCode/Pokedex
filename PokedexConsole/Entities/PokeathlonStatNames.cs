using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class PokeathlonStatNames
    {
        public long PokeathlonStatId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }

        public virtual Languages LocalLanguage { get; set; }
        public virtual PokeathlonStats PokeathlonStat { get; set; }
    }
}
