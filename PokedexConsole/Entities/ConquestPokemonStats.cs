using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class ConquestPokemonStats
    {
        public long PokemonSpeciesId { get; set; }
        public long ConquestStatId { get; set; }
        public long BaseStat { get; set; }

        public virtual ConquestStats ConquestStat { get; set; }
        public virtual PokemonSpecies PokemonSpecies { get; set; }
    }
}
