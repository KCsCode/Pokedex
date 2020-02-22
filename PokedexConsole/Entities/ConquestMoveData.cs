using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class ConquestMoveData
    {
        public long MoveId { get; set; }
        public long? Power { get; set; }
        public long? Accuracy { get; set; }
        public long? EffectChance { get; set; }
        public long EffectId { get; set; }
        public long RangeId { get; set; }
        public long? DisplacementId { get; set; }

        public virtual ConquestMoveDisplacements Displacement { get; set; }
        public virtual ConquestMoveEffects Effect { get; set; }
        public virtual Moves Move { get; set; }
        public virtual ConquestMoveRanges Range { get; set; }
    }
}
