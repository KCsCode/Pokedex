using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class ConquestKingdoms
    {
        public ConquestKingdoms()
        {
            ConquestKingdomNames = new HashSet<ConquestKingdomNames>();
            ConquestPokemonEvolution = new HashSet<ConquestPokemonEvolution>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }
        public long TypeId { get; set; }

        public virtual Types Type { get; set; }
        public virtual ICollection<ConquestKingdomNames> ConquestKingdomNames { get; set; }
        public virtual ICollection<ConquestPokemonEvolution> ConquestPokemonEvolution { get; set; }
    }
}
