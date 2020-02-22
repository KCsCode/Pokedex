using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class ContestEffects
    {
        public ContestEffects()
        {
            ContestEffectProse = new HashSet<ContestEffectProse>();
            Moves = new HashSet<Moves>();
        }

        public long Id { get; set; }
        public long Appeal { get; set; }
        public long Jam { get; set; }

        public virtual ICollection<ContestEffectProse> ContestEffectProse { get; set; }
        public virtual ICollection<Moves> Moves { get; set; }
    }
}
