using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class NaturePokeathlonStats
    {
        public long NatureId { get; set; }
        public long PokeathlonStatId { get; set; }
        public long MaxChange { get; set; }

        public virtual Natures Nature { get; set; }
        public virtual PokeathlonStats PokeathlonStat { get; set; }
    }
}
