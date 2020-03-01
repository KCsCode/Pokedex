using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class PalPark
    {
        public long SpeciesId { get; set; }
        public long AreaId { get; set; }
        public long BaseScore { get; set; }
        public long Rate { get; set; }

        public virtual PalParkAreas Area { get; set; }
        public virtual PokemonSpecies Species { get; set; }
    }
}
