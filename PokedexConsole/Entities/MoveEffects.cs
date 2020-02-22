using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class MoveEffects
    {
        public MoveEffects()
        {
            MoveChangelog = new HashSet<MoveChangelog>();
            MoveEffectChangelog = new HashSet<MoveEffectChangelog>();
            MoveEffectProse = new HashSet<MoveEffectProse>();
            Moves = new HashSet<Moves>();
        }

        public long Id { get; set; }

        public virtual ICollection<MoveChangelog> MoveChangelog { get; set; }
        public virtual ICollection<MoveEffectChangelog> MoveEffectChangelog { get; set; }
        public virtual ICollection<MoveEffectProse> MoveEffectProse { get; set; }
        public virtual ICollection<Moves> Moves { get; set; }
    }
}
