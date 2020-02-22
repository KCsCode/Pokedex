using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class PokemonMoves
    {
        public long PokemonId { get; set; }
        public long VersionGroupId { get; set; }
        public long MoveId { get; set; }
        public long PokemonMoveMethodId { get; set; }
        public long Level { get; set; }
        public long? Order { get; set; }

        public virtual Moves Move { get; set; }
        public virtual Pokemon Pokemon { get; set; }
        public virtual PokemonMoveMethods PokemonMoveMethod { get; set; }
        public virtual VersionGroups VersionGroup { get; set; }
    }
}
