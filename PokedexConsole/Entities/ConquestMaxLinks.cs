using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class ConquestMaxLinks
    {
        public long WarriorRankId { get; set; }
        public long PokemonSpeciesId { get; set; }
        public long MaxLink { get; set; }

        public virtual PokemonSpecies PokemonSpecies { get; set; }
        public virtual ConquestWarriorRanks WarriorRank { get; set; }
    }
}
