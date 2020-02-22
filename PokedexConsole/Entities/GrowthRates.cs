using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class GrowthRates
    {
        public GrowthRates()
        {
            Experience = new HashSet<Experience>();
            GrowthRateProse = new HashSet<GrowthRateProse>();
            PokemonSpecies = new HashSet<PokemonSpecies>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }
        public string Formula { get; set; }

        public virtual ICollection<Experience> Experience { get; set; }
        public virtual ICollection<GrowthRateProse> GrowthRateProse { get; set; }
        public virtual ICollection<PokemonSpecies> PokemonSpecies { get; set; }
    }
}
