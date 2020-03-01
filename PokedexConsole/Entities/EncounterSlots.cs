using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class EncounterSlots
    {
        public EncounterSlots()
        {
            Encounters = new HashSet<Encounters>();
        }

        public long Id { get; set; }
        public long VersionGroupId { get; set; }
        public long EncounterMethodId { get; set; }
        public long? Slot { get; set; }
        public long? Rarity { get; set; }

        public virtual EncounterMethods EncounterMethod { get; set; }
        public virtual VersionGroups VersionGroup { get; set; }
        public virtual ICollection<Encounters> Encounters { get; set; }
    }
}
