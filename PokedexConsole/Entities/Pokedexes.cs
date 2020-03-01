using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class Pokedexes
    {
        public Pokedexes()
        {
            PokedexProse = new HashSet<PokedexProse>();
            PokedexVersionGroups = new HashSet<PokedexVersionGroups>();
            PokemonDexNumbers = new HashSet<PokemonDexNumbers>();
        }

        public long Id { get; set; }
        public long? RegionId { get; set; }
        public string Identifier { get; set; }
        public byte[] IsMainSeries { get; set; }

        public virtual Regions Region { get; set; }
        public virtual ICollection<PokedexProse> PokedexProse { get; set; }
        public virtual ICollection<PokedexVersionGroups> PokedexVersionGroups { get; set; }
        public virtual ICollection<PokemonDexNumbers> PokemonDexNumbers { get; set; }
    }
}
