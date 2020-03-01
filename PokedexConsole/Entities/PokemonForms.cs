using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class PokemonForms
    {
        public PokemonForms()
        {
            PokemonFormGenerations = new HashSet<PokemonFormGenerations>();
            PokemonFormNames = new HashSet<PokemonFormNames>();
            PokemonFormPokeathlonStats = new HashSet<PokemonFormPokeathlonStats>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }
        public string FormIdentifier { get; set; }
        public long PokemonId { get; set; }
        public long? IntroducedInVersionGroupId { get; set; }
        public byte[] IsDefault { get; set; }
        public byte[] IsBattleOnly { get; set; }
        public byte[] IsMega { get; set; }
        public long FormOrder { get; set; }
        public long Order { get; set; }

        public virtual VersionGroups IntroducedInVersionGroup { get; set; }
        public virtual Pokemon Pokemon { get; set; }
        public virtual ICollection<PokemonFormGenerations> PokemonFormGenerations { get; set; }
        public virtual ICollection<PokemonFormNames> PokemonFormNames { get; set; }
        public virtual ICollection<PokemonFormPokeathlonStats> PokemonFormPokeathlonStats { get; set; }
    }
}
