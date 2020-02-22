using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class Encounters
    {
        public Encounters()
        {
            EncounterConditionValueMap = new HashSet<EncounterConditionValueMap>();
        }

        public long Id { get; set; }
        public long VersionId { get; set; }
        public long LocationAreaId { get; set; }
        public long EncounterSlotId { get; set; }
        public long PokemonId { get; set; }
        public long MinLevel { get; set; }
        public long MaxLevel { get; set; }

        public virtual EncounterSlots EncounterSlot { get; set; }
        public virtual LocationAreas LocationArea { get; set; }
        public virtual Pokemon Pokemon { get; set; }
        public virtual Versions Version { get; set; }
        public virtual ICollection<EncounterConditionValueMap> EncounterConditionValueMap { get; set; }
    }
}
