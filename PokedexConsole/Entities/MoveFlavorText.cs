using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class MoveFlavorText
    {
        public long MoveId { get; set; }
        public long VersionGroupId { get; set; }
        public long LanguageId { get; set; }
        public string FlavorText { get; set; }

        public virtual Languages Language { get; set; }
        public virtual Moves Move { get; set; }
        public virtual VersionGroups VersionGroup { get; set; }
    }
}
