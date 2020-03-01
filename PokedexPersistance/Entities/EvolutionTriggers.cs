using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class EvolutionTriggers
    {
        public EvolutionTriggers()
        {
            EvolutionTriggerProse = new HashSet<EvolutionTriggerProse>();
            PokemonEvolution = new HashSet<PokemonEvolution>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<EvolutionTriggerProse> EvolutionTriggerProse { get; set; }
        public virtual ICollection<PokemonEvolution> PokemonEvolution { get; set; }
    }
}
