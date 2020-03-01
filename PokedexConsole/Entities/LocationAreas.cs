using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class LocationAreas
    {
        public LocationAreas()
        {
            Encounters = new HashSet<Encounters>();
            LocationAreaEncounterRates = new HashSet<LocationAreaEncounterRates>();
            LocationAreaProse = new HashSet<LocationAreaProse>();
        }

        public long Id { get; set; }
        public long LocationId { get; set; }
        public long GameIndex { get; set; }
        public string Identifier { get; set; }

        public virtual Locations Location { get; set; }
        public virtual ICollection<Encounters> Encounters { get; set; }
        public virtual ICollection<LocationAreaEncounterRates> LocationAreaEncounterRates { get; set; }
        public virtual ICollection<LocationAreaProse> LocationAreaProse { get; set; }
    }
}
