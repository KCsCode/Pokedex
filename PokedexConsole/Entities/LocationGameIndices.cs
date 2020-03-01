using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class LocationGameIndices
    {
        public long LocationId { get; set; }
        public long GenerationId { get; set; }
        public long GameIndex { get; set; }

        public virtual Generations Generation { get; set; }
        public virtual Locations Location { get; set; }
    }
}
