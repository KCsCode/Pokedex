using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class EncounterConditionProse
    {
        public long EncounterConditionId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }

        public virtual EncounterConditions EncounterCondition { get; set; }
        public virtual Languages LocalLanguage { get; set; }
    }
}
