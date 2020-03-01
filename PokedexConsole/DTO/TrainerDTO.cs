using System;
using System.Collections.Generic;
using System.Text;

namespace PokedexConsole.DTO
{
    public partial class TrainerDTO
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public List<PokemonDTO> PokemonRoster { get; set; }

    }
}
