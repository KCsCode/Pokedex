using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class NatureBattleStylePreferences
    {
        public long NatureId { get; set; }
        public long MoveBattleStyleId { get; set; }
        public long LowHpPreference { get; set; }
        public long HighHpPreference { get; set; }

        public virtual MoveBattleStyles MoveBattleStyle { get; set; }
        public virtual Natures Nature { get; set; }
    }
}
