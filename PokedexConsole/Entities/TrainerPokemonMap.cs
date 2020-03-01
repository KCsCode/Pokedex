using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class TrainerPokemonMap
    {
        public long Id { get; set; }
        public long TrainerId { get; set; }
        public long PokemonId { get; set; }

        public virtual Pokemon Pokemon { get; set; }
    }
}
