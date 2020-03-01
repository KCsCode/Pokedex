using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class SuperContestEffects
    {
        public SuperContestEffects()
        {
            Moves = new HashSet<Moves>();
            SuperContestEffectProse = new HashSet<SuperContestEffectProse>();
        }

        public long Id { get; set; }
        public long Appeal { get; set; }

        public virtual ICollection<Moves> Moves { get; set; }
        public virtual ICollection<SuperContestEffectProse> SuperContestEffectProse { get; set; }
    }
}
