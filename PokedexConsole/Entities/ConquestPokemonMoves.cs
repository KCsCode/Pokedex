using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class ConquestPokemonMoves
    {
        public long PokemonSpeciesId { get; set; }
        public long MoveId { get; set; }

        public virtual Moves Move { get; set; }
        public virtual PokemonSpecies PokemonSpecies { get; set; }
    }
}
