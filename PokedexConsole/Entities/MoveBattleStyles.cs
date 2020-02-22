using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class MoveBattleStyles
    {
        public MoveBattleStyles()
        {
            MoveBattleStyleProse = new HashSet<MoveBattleStyleProse>();
            NatureBattleStylePreferences = new HashSet<NatureBattleStylePreferences>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<MoveBattleStyleProse> MoveBattleStyleProse { get; set; }
        public virtual ICollection<NatureBattleStylePreferences> NatureBattleStylePreferences { get; set; }
    }
}
