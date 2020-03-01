using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class BerryFlavors
    {
        public long BerryId { get; set; }
        public long ContestTypeId { get; set; }
        public long Flavor { get; set; }

        public virtual Berries Berry { get; set; }
        public virtual ContestTypes ContestType { get; set; }
    }
}
