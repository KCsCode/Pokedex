using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class PokedexVersionGroups
    {
        public long PokedexId { get; set; }
        public long VersionGroupId { get; set; }

        public virtual Pokedexes Pokedex { get; set; }
        public virtual VersionGroups VersionGroup { get; set; }
    }
}
