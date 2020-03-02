using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PokedexAPI.Business;
using PokedexDTOs.RequestDTO;
using PokedexDTOs.ResponseDTO;

namespace PokedexAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainerController : ControllerBase
    {
        private readonly IPokemonService _pokemonService;

        /// <summary>
        /// Creates a new instance of the <see cref="TrainerController"/> class.
        /// </summary>
        public TrainerController(IPokemonService pokemonService)
        {
            _pokemonService = pokemonService ?? throw new ArgumentNullException(nameof(pokemonService));
        }

        [Authorize("Test")]
        [Route("v1/get-all-trainers")]
        [HttpGet]
        public IActionResult GetAllTrainers()
        {
            IActionResult result = BadRequest();

            IEnumerable<TrainerResponseDTO> response = _pokemonService.GetAllTrainers();
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

        [Authorize("Test")]
        [Route("v1/get-trainer")]
        [HttpGet]
        public IActionResult GetTrainerById([FromQuery]RequestByIdDTO request)
        {
            IActionResult result = BadRequest();

            if (request != null)
            {
                TrainerResponseDTO response = _pokemonService.GetTrainerById(request);

                if (response != null)
                {
                    result = Ok(response);
                }
            }

            return result;
        }

        [Authorize("Test")]
        [Route("v1/register")]
        [HttpPost]
        public IActionResult RegisterPokemonToTrainer(TrainerPokemonRequestDTO request)
        {
            IActionResult result = BadRequest();
            if (request != null)
            {
                string response = _pokemonService.RegisterPokemonToTrainer(request);

                if (response == null)
                {
                    result = Ok();
                }
                else
                {
                    result = BadRequest(response);
                }
            }
            
            return result;
        }

        [Authorize("Test")]
        [Route("v1/unregister")]
        [HttpPost]
        public IActionResult UnregisterPokemonToTrainer(TrainerPokemonRequestDTO request)
        {
            IActionResult result = BadRequest();

            if (request != null)
            {
                string response = _pokemonService.UnregisterPokemonToTrainer(request);

                if (response == null)
                {
                    result = Ok();
                }
                else
                {
                    result = BadRequest(response);
                }
            }
              
            return result;
        }

        [Authorize("Test")]
        [Route("v1/create-trainer")]
        [HttpPost]
        public IActionResult CreateTrainer(TrainerRequestDTO request)
        {
            IActionResult result = BadRequest();

            if (request != null)
            {
                string response = _pokemonService.CreateTrainer(request);

                if (response == null)
                {
                    result = Ok();
                }
                else
                {
                    result = BadRequest(response);
                }
            }
            
            return result; 
        }

        [Authorize("Test")]
        [Route("v1/update-trainer")]
        [HttpPut]
        public IActionResult UpdateTrainer(TrainerRequestDTO request)
        {
            IActionResult result = BadRequest();

            if (request != null)
            {
                string response = _pokemonService.UpdateTrainer(request);
                
                if (response == null)
                {
                    result = Ok();
                }
                else
                {
                    result = BadRequest(response);
                }
            }

            return result;
        }

        [Authorize("Test")]
        [Route("v1/delete-trainer")]
        [HttpDelete]
        public IActionResult RemoveTrainer(RequestByIdDTO request)
        {
            IActionResult result = BadRequest();

            if (request != null)
            {
                string response = _pokemonService.RemoveTrainer(request);

                if (response == null)
                {
                    result = Ok();
                }
                else
                {
                    result = BadRequest(response);
                }

            }

            return result;
        }
    }
}