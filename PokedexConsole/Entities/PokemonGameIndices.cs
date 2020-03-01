using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class PokemonGameIndices
    {
        public long PokemonId { get; set; }
        public long VersionId { get; set; }
        public long GameIndex { get; set; }

        public virtual Pokemon Pokemon { get; set; }
        public virtual Versions Version { get; set; }
    }
}
