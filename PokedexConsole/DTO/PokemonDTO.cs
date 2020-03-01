using PokedexConsole.Entities;
using System.Collections.Generic;

namespace PokedexConsole.DTO
{
    public partial class PokemonDTO
    {
        public string PokemonName { get; set; }
        public long? PokedexId { get; set; }
        public long Height { get; set; }
        public long Weight { get; set; }
        public long BaseExperience { get; set; }
        public List<TypeDTO> Types { get; set; }
    }
}
