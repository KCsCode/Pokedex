using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class ConquestMoveEffects
    {
        public ConquestMoveEffects()
        {
            ConquestMoveData = new HashSet<ConquestMoveData>();
            ConquestMoveEffectProse = new HashSet<ConquestMoveEffectProse>();
        }

        public long Id { get; set; }

        public virtual ICollection<ConquestMoveData> ConquestMoveData { get; set; }
        public virtual ICollection<ConquestMoveEffectProse> ConquestMoveEffectProse { get; set; }
    }
}
