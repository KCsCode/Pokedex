using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class PokemonSpeciesFlavorText
    {
        public long SpeciesId { get; set; }
        public long VersionId { get; set; }
        public long LanguageId { get; set; }
        public string FlavorText { get; set; }

        public virtual Languages Language { get; set; }
        public virtual PokemonSpecies Species { get; set; }
        public virtual Versions Version { get; set; }
    }
}
