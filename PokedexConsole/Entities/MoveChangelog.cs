using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class MoveChangelog
    {
        public long MoveId { get; set; }
        public long ChangedInVersionGroupId { get; set; }
        public long? TypeId { get; set; }
        public long? Power { get; set; }
        public long? Pp { get; set; }
        public long? Accuracy { get; set; }
        public long? Priority { get; set; }
        public long? TargetId { get; set; }
        public long? EffectId { get; set; }
        public long? EffectChance { get; set; }

        public virtual VersionGroups ChangedInVersionGroup { get; set; }
        public virtual MoveEffects Effect { get; set; }
        public virtual Moves Move { get; set; }
        public virtual MoveTargets Target { get; set; }
        public virtual Types Type { get; set; }
    }
}
