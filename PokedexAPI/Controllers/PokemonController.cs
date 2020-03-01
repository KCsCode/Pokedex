using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PokedexConsole.Entities;
using PokedexConsole.DTO;
using PokedexAPI.DTO;
using System;

namespace PokedexAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly PokedexContext _context;

        public PokemonController(PokedexContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PokemonDTO>>> GetPokemonById([FromQuery]IdRequestDTO request)
        {
            
            Pokemon pokemon = await _context.Pokemon.AsNoTracking()
                .Include(x => x.PokemonTypes).FirstOrDefaultAsync(x => x.Id == request.Id);

            if (pokemon == null)
            {
                return NotFound();
            }

            return Ok(PokemonToDTO(pokemon, _context));
        }

        [Route("type")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PokemonDTO>>> GetPokemonByTypeId([FromQuery]IdRequestDTO request)
        {
            var typeId = await _context.Types.AsNoTracking().FirstOrDefaultAsync(x => x.Id == request.Id);
            if (typeId == null)
            {
                return NotFound();
            }
            return await _context.Pokemon.AsNoTracking()
                .Include(x => x.PokemonTypes)
                .Where(x => x.PokemonTypes.Any(y => y.TypeId == request.Id))
                .Select(x => PokemonToDTO(x, _context)).ToListAsync();
        }
        //[HttpGet]
        //[HttpGet("entity")]
        //public async Task<ActionResult<IEnumerable<Pokemon>>> GetPokemonEntity()
        //{
        //    return await _context.Pokemon.Include(t => t.PokemonTypes).Take(5).ToListAsync();
        //}

        public static PokemonDTO PokemonToDTO(Pokemon pokemon, PokedexContext context)
        {
            List<TypeDTO> types = new List<TypeDTO>();

            foreach (PokemonTypes type in pokemon.PokemonTypes ?? Enumerable.Empty<PokemonTypes>())
            {
                types.Add(new TypeDTO()
                {
                    Name = context.Types.AsNoTracking().FirstOrDefault(x => x.Id == type.TypeId)?.Identifier,
                    Id = type.TypeId 
                });
            }

            return new PokemonDTO
            {
                PokemonName = pokemon.Identifier,
                PokedexId = pokemon.SpeciesId,
                Height = pokemon.Height,
                Weight = pokemon.Weight,
                BaseExperience = pokemon.BaseExperience,
                Types = types
            };
        }
    }
}