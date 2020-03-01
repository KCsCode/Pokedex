using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class EncounterMethods
    {
        public EncounterMethods()
        {
            EncounterMethodProse = new HashSet<EncounterMethodProse>();
            EncounterSlots = new HashSet<EncounterSlots>();
            LocationAreaEncounterRates = new HashSet<LocationAreaEncounterRates>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }
        public long Order { get; set; }

        public virtual ICollection<EncounterMethodProse> EncounterMethodProse { get; set; }
        public virtual ICollection<EncounterSlots> EncounterSlots { get; set; }
        public virtual ICollection<LocationAreaEncounterRates> LocationAreaEncounterRates { get; set; }
    }
}
