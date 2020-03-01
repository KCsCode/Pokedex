using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class PokemonFormNames
    {
        public long PokemonFormId { get; set; }
        public long LocalLanguageId { get; set; }
        public string FormName { get; set; }
        public string PokemonName { get; set; }

        public virtual Languages LocalLanguage { get; set; }
        public virtual PokemonForms PokemonForm { get; set; }
    }
}
