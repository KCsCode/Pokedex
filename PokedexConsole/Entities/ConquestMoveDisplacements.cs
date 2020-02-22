using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class ConquestMoveDisplacements
    {
        public ConquestMoveDisplacements()
        {
            ConquestMoveData = new HashSet<ConquestMoveData>();
            ConquestMoveDisplacementProse = new HashSet<ConquestMoveDisplacementProse>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }
        public byte[] AffectsTarget { get; set; }

        public virtual ICollection<ConquestMoveData> ConquestMoveData { get; set; }
        public virtual ICollection<ConquestMoveDisplacementProse> ConquestMoveDisplacementProse { get; set; }
    }
}
