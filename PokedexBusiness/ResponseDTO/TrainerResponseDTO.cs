using System;
using System.Collections.Generic;
using System.Text;

namespace PokedexDTOs.ResponseDTO
{
    public partial class TrainerResponseDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public List<PokemonResponseDTO> RegisteredPokemon { get; set; }

    }
}
