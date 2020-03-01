using System.Collections.Generic;

namespace PokedexDTOs.ResponseDTO
{
    public partial class PokemonResponseDTO
    {
        public string PokemonName { get; set; }
        public long? PokedexId { get; set; }
        public long Height { get; set; }
        public long Weight { get; set; }
        public long BaseExperience { get; set; }
        public List<TypeResponseDTO> Types { get; set; }
    }
}
