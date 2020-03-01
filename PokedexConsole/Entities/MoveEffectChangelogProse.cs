using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class MoveEffectChangelogProse
    {
        public long MoveEffectChangelogId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Effect { get; set; }

        public virtual Languages LocalLanguage { get; set; }
        public virtual MoveEffectChangelog MoveEffectChangelog { get; set; }
    }
}
