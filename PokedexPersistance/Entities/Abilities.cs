using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class Abilities
    {
        public Abilities()
        {
            AbilityChangelog = new HashSet<AbilityChangelog>();
            AbilityFlavorText = new HashSet<AbilityFlavorText>();
            AbilityNames = new HashSet<AbilityNames>();
            AbilityProse = new HashSet<AbilityProse>();
            ConquestPokemonAbilities = new HashSet<ConquestPokemonAbilities>();
            PokemonAbilities = new HashSet<PokemonAbilities>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }
        public long GenerationId { get; set; }
        public byte[] IsMainSeries { get; set; }

        public virtual Generations Generation { get; set; }
        public virtual ICollection<AbilityChangelog> AbilityChangelog { get; set; }
        public virtual ICollection<AbilityFlavorText> AbilityFlavorText { get; set; }
        public virtual ICollection<AbilityNames> AbilityNames { get; set; }
        public virtual ICollection<AbilityProse> AbilityProse { get; set; }
        public virtual ICollection<ConquestPokemonAbilities> ConquestPokemonAbilities { get; set; }
        public virtual ICollection<PokemonAbilities> PokemonAbilities { get; set; }
    }
}
