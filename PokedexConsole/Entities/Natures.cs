using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class Natures
    {
        public Natures()
        {
            NatureBattleStylePreferences = new HashSet<NatureBattleStylePreferences>();
            NatureNames = new HashSet<NatureNames>();
            NaturePokeathlonStats = new HashSet<NaturePokeathlonStats>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }
        public long DecreasedStatId { get; set; }
        public long IncreasedStatId { get; set; }
        public long HatesFlavorId { get; set; }
        public long LikesFlavorId { get; set; }
        public long GameIndex { get; set; }

        public virtual Stats DecreasedStat { get; set; }
        public virtual ContestTypes HatesFlavor { get; set; }
        public virtual Stats IncreasedStat { get; set; }
        public virtual ContestTypes LikesFlavor { get; set; }
        public virtual ICollection<NatureBattleStylePreferences> NatureBattleStylePreferences { get; set; }
        public virtual ICollection<NatureNames> NatureNames { get; set; }
        public virtual ICollection<NaturePokeathlonStats> NaturePokeathlonStats { get; set; }
    }
}
