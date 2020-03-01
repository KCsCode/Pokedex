using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class PokemonStats
    {
        public long PokemonId { get; set; }
        public long StatId { get; set; }
        public long BaseStat { get; set; }
        public long Effort { get; set; }

        public virtual Pokemon Pokemon { get; set; }
        public virtual Stats Stat { get; set; }
    }
}
