using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PokedexConsole.Entities;
using PokedexConsole.DTO;
namespace PokedexAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly PokedexContext _context;

        public PokemonController(PokedexContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PokemonDTO>>> GetPokemon()
        {
            return await _context.Pokemon.Select(x => PokemonToDTO(x)).ToListAsync();
        }

        private static PokemonDTO PokemonToDTO(Pokemon pokemon) =>
            new PokemonDTO
            {
                Identifier = pokemon.Identifier,
                SpeciesId = pokemon.SpeciesId,
                Height = pokemon.Height,
                Weight = pokemon.Weight,
                BaseExperience = pokemon.BaseExperience
            };
    }
}