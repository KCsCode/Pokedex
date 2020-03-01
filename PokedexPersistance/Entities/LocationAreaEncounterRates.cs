using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class LocationAreaEncounterRates
    {
        public long LocationAreaId { get; set; }
        public long EncounterMethodId { get; set; }
        public long VersionId { get; set; }
        public long? Rate { get; set; }

        public virtual EncounterMethods EncounterMethod { get; set; }
        public virtual LocationAreas LocationArea { get; set; }
        public virtual Versions Version { get; set; }
    }
}
