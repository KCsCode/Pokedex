using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PokedexAPI.Business;
using PokedexDTOs.RequestDTO;
using PokedexDTOs.ResponseDTO;

namespace PokedexAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly IPokemonService _pokemonService;

        public PokemonController(IPokemonService pokemonService)
        {
            _pokemonService = pokemonService ?? throw new ArgumentNullException(nameof(pokemonService));
        }

        [Route("v1/get-pokemon")]
        [HttpGet]
        public IActionResult GetPokemonById([FromQuery]RequestByIdDTO request)
        {
            IActionResult result = BadRequest();

            if (request != null)
            {
                PokemonResponseDTO response = _pokemonService.GetPokemonById(request);
                if (response != null)
                {
                    result = Ok(response);
                }
                else
                {
                    result = NotFound();
                }
            }

            return result;
        }

        [Route("v1/type")]
        [HttpGet]
        public IActionResult GetPokemonByTypeId([FromQuery]RequestByIdDTO request)
        {
            IActionResult result = BadRequest();
            if (request != null)
            {
                IEnumerable<PokemonResponseDTO> response = _pokemonService.GetPokemonByTypeId(request);
                if (response != null)
                {
                    result = Ok(response);
                }
                else
                {
                    result = NotFound();
                }
            }
            
            return result;
        }
    }
}