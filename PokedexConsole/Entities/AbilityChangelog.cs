using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class AbilityChangelog
    {
        public AbilityChangelog()
        {
            AbilityChangelogProse = new HashSet<AbilityChangelogProse>();
        }

        public long Id { get; set; }
        public long AbilityId { get; set; }
        public long ChangedInVersionGroupId { get; set; }

        public virtual Abilities Ability { get; set; }
        public virtual VersionGroups ChangedInVersionGroup { get; set; }
        public virtual ICollection<AbilityChangelogProse> AbilityChangelogProse { get; set; }
    }
}
