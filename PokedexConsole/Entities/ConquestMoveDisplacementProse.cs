using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class ConquestMoveDisplacementProse
    {
        public long MoveDisplacementId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }
        public string ShortEffect { get; set; }
        public string Effect { get; set; }

        public virtual Languages LocalLanguage { get; set; }
        public virtual ConquestMoveDisplacements MoveDisplacement { get; set; }
    }
}
