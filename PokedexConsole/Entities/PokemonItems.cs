using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class PokemonItems
    {
        public long PokemonId { get; set; }
        public long VersionId { get; set; }
        public long ItemId { get; set; }
        public long Rarity { get; set; }

        public virtual Items Item { get; set; }
        public virtual Pokemon Pokemon { get; set; }
        public virtual Versions Version { get; set; }
    }
}
