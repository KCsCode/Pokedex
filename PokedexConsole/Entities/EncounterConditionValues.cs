using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class EncounterConditionValues
    {
        public EncounterConditionValues()
        {
            EncounterConditionValueMap = new HashSet<EncounterConditionValueMap>();
            EncounterConditionValueProse = new HashSet<EncounterConditionValueProse>();
        }

        public long Id { get; set; }
        public long EncounterConditionId { get; set; }
        public string Identifier { get; set; }
        public byte[] IsDefault { get; set; }

        public virtual EncounterConditions EncounterCondition { get; set; }
        public virtual ICollection<EncounterConditionValueMap> EncounterConditionValueMap { get; set; }
        public virtual ICollection<EncounterConditionValueProse> EncounterConditionValueProse { get; set; }
    }
}
