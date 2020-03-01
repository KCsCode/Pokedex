using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class EvolutionChains
    {
        public EvolutionChains()
        {
            PokemonSpecies = new HashSet<PokemonSpecies>();
        }

        public long Id { get; set; }
        public long? BabyTriggerItemId { get; set; }

        public virtual Items BabyTriggerItem { get; set; }
        public virtual ICollection<PokemonSpecies> PokemonSpecies { get; set; }
    }
}
