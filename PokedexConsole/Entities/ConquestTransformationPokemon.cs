using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class ConquestTransformationPokemon
    {
        public long TransformationId { get; set; }
        public long PokemonSpeciesId { get; set; }

        public virtual PokemonSpecies PokemonSpecies { get; set; }
        public virtual ConquestWarriorTransformation Transformation { get; set; }
    }
}
