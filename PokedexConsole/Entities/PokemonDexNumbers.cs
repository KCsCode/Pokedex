using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class PokemonDexNumbers
    {
        public long SpeciesId { get; set; }
        public long PokedexId { get; set; }
        public long PokedexNumber { get; set; }

        public virtual Pokedexes Pokedex { get; set; }
        public virtual PokemonSpecies Species { get; set; }
    }
}
