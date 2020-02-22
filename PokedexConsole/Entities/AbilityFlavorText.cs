using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class AbilityFlavorText
    {
        public long AbilityId { get; set; }
        public long VersionGroupId { get; set; }
        public long LanguageId { get; set; }
        public string FlavorText { get; set; }

        public virtual Abilities Ability { get; set; }
        public virtual Languages Language { get; set; }
        public virtual VersionGroups VersionGroup { get; set; }
    }
}
