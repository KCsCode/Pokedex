using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class PokemonMoveMethods
    {
        public PokemonMoveMethods()
        {
            PokemonMoveMethodProse = new HashSet<PokemonMoveMethodProse>();
            PokemonMoves = new HashSet<PokemonMoves>();
            VersionGroupPokemonMoveMethods = new HashSet<VersionGroupPokemonMoveMethods>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<PokemonMoveMethodProse> PokemonMoveMethodProse { get; set; }
        public virtual ICollection<PokemonMoves> PokemonMoves { get; set; }
        public virtual ICollection<VersionGroupPokemonMoveMethods> VersionGroupPokemonMoveMethods { get; set; }
    }
}
