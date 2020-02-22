using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class EncounterMethodProse
    {
        public long EncounterMethodId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }

        public virtual EncounterMethods EncounterMethod { get; set; }
        public virtual Languages LocalLanguage { get; set; }
    }
}
