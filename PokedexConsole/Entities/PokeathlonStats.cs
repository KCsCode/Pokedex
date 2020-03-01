using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class PokeathlonStats
    {
        public PokeathlonStats()
        {
            NaturePokeathlonStats = new HashSet<NaturePokeathlonStats>();
            PokeathlonStatNames = new HashSet<PokeathlonStatNames>();
            PokemonFormPokeathlonStats = new HashSet<PokemonFormPokeathlonStats>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<NaturePokeathlonStats> NaturePokeathlonStats { get; set; }
        public virtual ICollection<PokeathlonStatNames> PokeathlonStatNames { get; set; }
        public virtual ICollection<PokemonFormPokeathlonStats> PokemonFormPokeathlonStats { get; set; }
    }
}
