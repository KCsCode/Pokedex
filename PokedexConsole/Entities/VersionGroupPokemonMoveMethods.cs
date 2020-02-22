using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class VersionGroupPokemonMoveMethods
    {
        public long VersionGroupId { get; set; }
        public long PokemonMoveMethodId { get; set; }

        public virtual PokemonMoveMethods PokemonMoveMethod { get; set; }
        public virtual VersionGroups VersionGroup { get; set; }
    }
}
