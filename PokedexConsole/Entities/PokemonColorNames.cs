using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class PokemonColorNames
    {
        public long PokemonColorId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }

        public virtual Languages LocalLanguage { get; set; }
        public virtual PokemonColors PokemonColor { get; set; }
    }
}
