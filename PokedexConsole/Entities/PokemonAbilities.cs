using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class PokemonAbilities
    {
        public long PokemonId { get; set; }
        public long AbilityId { get; set; }
        public byte[] IsHidden { get; set; }
        public long Slot { get; set; }

        public virtual Abilities Ability { get; set; }
        public virtual Pokemon Pokemon { get; set; }
    }
}
