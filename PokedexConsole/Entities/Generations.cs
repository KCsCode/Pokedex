using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class Generations
    {
        public Generations()
        {
            Abilities = new HashSet<Abilities>();
            GenerationNames = new HashSet<GenerationNames>();
            ItemGameIndices = new HashSet<ItemGameIndices>();
            LocationGameIndices = new HashSet<LocationGameIndices>();
            Moves = new HashSet<Moves>();
            PokemonFormGenerations = new HashSet<PokemonFormGenerations>();
            PokemonSpecies = new HashSet<PokemonSpecies>();
            TypeGameIndices = new HashSet<TypeGameIndices>();
            Types = new HashSet<Types>();
            VersionGroups = new HashSet<VersionGroups>();
        }

        public long Id { get; set; }
        public long MainRegionId { get; set; }
        public string Identifier { get; set; }

        public virtual Regions MainRegion { get; set; }
        public virtual ICollection<Abilities> Abilities { get; set; }
        public virtual ICollection<GenerationNames> GenerationNames { get; set; }
        public virtual ICollection<ItemGameIndices> ItemGameIndices { get; set; }
        public virtual ICollection<LocationGameIndices> LocationGameIndices { get; set; }
        public virtual ICollection<Moves> Moves { get; set; }
        public virtual ICollection<PokemonFormGenerations> PokemonFormGenerations { get; set; }
        public virtual ICollection<PokemonSpecies> PokemonSpecies { get; set; }
        public virtual ICollection<TypeGameIndices> TypeGameIndices { get; set; }
        public virtual ICollection<Types> Types { get; set; }
        public virtual ICollection<VersionGroups> VersionGroups { get; set; }
    }
}
