using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class PokemonFormPokeathlonStats
    {
        public long PokemonFormId { get; set; }
        public long PokeathlonStatId { get; set; }
        public long MinimumStat { get; set; }
        public long BaseStat { get; set; }
        public long MaximumStat { get; set; }

        public virtual PokeathlonStats PokeathlonStat { get; set; }
        public virtual PokemonForms PokemonForm { get; set; }
    }
}
