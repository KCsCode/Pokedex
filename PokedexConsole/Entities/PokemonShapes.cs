using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class PokemonShapes
    {
        public PokemonShapes()
        {
            PokemonShapeProse = new HashSet<PokemonShapeProse>();
            PokemonSpecies = new HashSet<PokemonSpecies>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<PokemonShapeProse> PokemonShapeProse { get; set; }
        public virtual ICollection<PokemonSpecies> PokemonSpecies { get; set; }
    }
}
