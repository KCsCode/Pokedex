using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class ConquestStats
    {
        public ConquestStats()
        {
            ConquestPokemonEvolution = new HashSet<ConquestPokemonEvolution>();
            ConquestPokemonStats = new HashSet<ConquestPokemonStats>();
            ConquestStatNames = new HashSet<ConquestStatNames>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }
        public byte[] IsBase { get; set; }

        public virtual ICollection<ConquestPokemonEvolution> ConquestPokemonEvolution { get; set; }
        public virtual ICollection<ConquestPokemonStats> ConquestPokemonStats { get; set; }
        public virtual ICollection<ConquestStatNames> ConquestStatNames { get; set; }
    }
}
