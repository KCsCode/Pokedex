using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PokedexAPI.Business;
using PokedexDTOs.ResponseDTO;

namespace PokedexAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeController : ControllerBase
    {
        private readonly IPokemonService _pokemonService;

        /// <summary>
        /// Creates a new instance of the <see cref="TypeController"/> class.
        /// </summary>
        public TypeController(IPokemonService pokemonService)
        {
            _pokemonService = pokemonService ?? throw new ArgumentNullException(nameof(pokemonService));
        }

        [Route("v1/get-types")]
        [HttpGet]
        public IActionResult GetTypes()
        {
            IActionResult result = BadRequest();
            List<TypeResponseDTO> response = _pokemonService.GetTypes();
            
            if (response != null)
            {
                result = Ok(response);
            }
            else
            {
                result = NotFound();
            }

            return result;
        }
    }
}