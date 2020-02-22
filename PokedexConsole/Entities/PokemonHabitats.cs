using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class PokemonHabitats
    {
        public PokemonHabitats()
        {
            PokemonHabitatNames = new HashSet<PokemonHabitatNames>();
            PokemonSpecies = new HashSet<PokemonSpecies>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<PokemonHabitatNames> PokemonHabitatNames { get; set; }
        public virtual ICollection<PokemonSpecies> PokemonSpecies { get; set; }
    }
}
