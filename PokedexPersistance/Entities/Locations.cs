using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class Locations
    {
        public Locations()
        {
            LocationAreas = new HashSet<LocationAreas>();
            LocationGameIndices = new HashSet<LocationGameIndices>();
            LocationNames = new HashSet<LocationNames>();
            PokemonEvolution = new HashSet<PokemonEvolution>();
        }

        public long Id { get; set; }
        public long? RegionId { get; set; }
        public string Identifier { get; set; }

        public virtual Regions Region { get; set; }
        public virtual ICollection<LocationAreas> LocationAreas { get; set; }
        public virtual ICollection<LocationGameIndices> LocationGameIndices { get; set; }
        public virtual ICollection<LocationNames> LocationNames { get; set; }
        public virtual ICollection<PokemonEvolution> PokemonEvolution { get; set; }
    }
}
