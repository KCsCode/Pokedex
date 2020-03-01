using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class PokemonSpeciesNames
    {
        public long PokemonSpeciesId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }
        public string Genus { get; set; }

        public virtual Languages LocalLanguage { get; set; }
        public virtual PokemonSpecies PokemonSpecies { get; set; }
    }
}
