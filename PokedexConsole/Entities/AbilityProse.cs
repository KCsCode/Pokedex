using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class AbilityProse
    {
        public long AbilityId { get; set; }
        public long LocalLanguageId { get; set; }
        public string ShortEffect { get; set; }
        public string Effect { get; set; }

        public virtual Abilities Ability { get; set; }
        public virtual Languages LocalLanguage { get; set; }
    }
}
