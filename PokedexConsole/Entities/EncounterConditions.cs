using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class EncounterConditions
    {
        public EncounterConditions()
        {
            EncounterConditionProse = new HashSet<EncounterConditionProse>();
            EncounterConditionValues = new HashSet<EncounterConditionValues>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<EncounterConditionProse> EncounterConditionProse { get; set; }
        public virtual ICollection<EncounterConditionValues> EncounterConditionValues { get; set; }
    }
}
