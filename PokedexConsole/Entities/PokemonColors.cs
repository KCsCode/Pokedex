using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class PokemonColors
    {
        public PokemonColors()
        {
            PokemonColorNames = new HashSet<PokemonColorNames>();
            PokemonSpecies = new HashSet<PokemonSpecies>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<PokemonColorNames> PokemonColorNames { get; set; }
        public virtual ICollection<PokemonSpecies> PokemonSpecies { get; set; }
    }
}
