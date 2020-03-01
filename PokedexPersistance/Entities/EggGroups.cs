using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class EggGroups
    {
        public EggGroups()
        {
            EggGroupProse = new HashSet<EggGroupProse>();
            PokemonEggGroups = new HashSet<PokemonEggGroups>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<EggGroupProse> EggGroupProse { get; set; }
        public virtual ICollection<PokemonEggGroups> PokemonEggGroups { get; set; }
    }
}
