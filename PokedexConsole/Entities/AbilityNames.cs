using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class AbilityNames
    {
        public long AbilityId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }

        public virtual Abilities Ability { get; set; }
        public virtual Languages LocalLanguage { get; set; }
    }
}
