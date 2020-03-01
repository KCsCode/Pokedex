using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokedexConsole.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using PokedexAPI.DTO;
using PokedexConsole.DTO;

namespace PokedexAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainerController : ControllerBase
    {
        private PokedexContext _context;

        public TrainerController(PokedexContext context)
        {
            _context = context;
        }

        [Authorize("Test")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrainerDTO>>> getAll()
        {
            return await _context.Trainer.AsNoTracking().Select(x => TrainerToDTO(x, _context))
                
                .ToListAsync();
        }

        [Authorize("Test")]
        [HttpGet]
        [Route("v1/get-trainer")]
        public async Task<ActionResult<IEnumerable<Trainer>>> GetTrainerById([FromQuery]IdRequestDTO request)
        {
            ActionResult response = NotFound();
            Trainer trainer = await _context.Trainer.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (trainer != null)
            {
                response = Ok(trainer);
            }
            return response;
        }

        [Authorize("Test")]
        [Route("register")]
        [HttpPost]
        public async Task<ActionResult<IEnumerable<Trainer>>> registerPokemonToTrainer(TrainerPokemonRequestDTO request)
        {
            ActionResult response;

            int pokemonCount = _context.TrainerPokemonMap.Where(x => x.TrainerId == request.TrainerId).Count();
            if (pokemonCount >= 6)
            {
                response = BadRequest("Trainer has too many pokemon. Remove Pokemon before registering additional pokemon");
            }
            else
            {
                TrainerPokemonMap trainerPokemon = new TrainerPokemonMap
                {
                    TrainerId = request.TrainerId,
                    PokemonId = request.PokemonId
                };
                _context.TrainerPokemonMap.Add(trainerPokemon);
                await _context.SaveChangesAsync();
                response = Ok();
            }

            return response;
        }

        [Authorize("Test")]
        [Route("unregister")]
        [HttpPost]
        public async Task<ActionResult<IEnumerable<Trainer>>> unregisterPokemonToTrainer(TrainerPokemonRequestDTO request)
        {
            ActionResult response = BadRequest();
            var pokemon = _context.TrainerPokemonMap
                .FirstOrDefault(x => request.TrainerId == x.TrainerId && request.PokemonId == x.PokemonId);

            if (pokemon != null)
            {
                {
                    _context.Remove(pokemon);
                    await _context.SaveChangesAsync();
                    response = Ok();
                }
            }
            return response;
        }


        [Authorize("Test")]
        [HttpPost]
        public async Task<ActionResult> CreateTrainer(TrainerRequestDTO request)
        {
            Trainer newTrainer = new Trainer
            {
                TrainerName = request.Name,
                Email = request.Email,
                ContactNumber = request.ContactNumber
            };
            _context.Trainer.Add(newTrainer);
            await _context.SaveChangesAsync();
            return Ok(); 

        }

        [Authorize("Test")]
        [HttpPut]
        public async Task<ActionResult> UpdateTrainer(TrainerRequestDTO request)
        {
            ActionResult response = NotFound();
            Trainer trainer = await _context.Trainer.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (trainer != null)
            {
                trainer.TrainerName = request.Name;
                trainer.Email = request.Email;
                trainer.ContactNumber = request.ContactNumber;

                try
                {
                    await _context.SaveChangesAsync();
                    response = Ok();
                }
                catch (DbUpdateConcurrencyException)
                {
                    response = BadRequest();
                }
            }

            return response;
        }

        [Authorize("Test")]
        [HttpDelete]
        public async Task<ActionResult> RemoveTrainer([FromQuery]IdRequestDTO request)
        {
            ActionResult response = NotFound();
            Trainer trainer = await _context.Trainer.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (trainer != null)
            {
                _context.Remove(trainer);
                await _context.SaveChangesAsync();
                response = Ok();
            }

            return response;
        }

        private static TrainerDTO TrainerToDTO(Trainer trainer, PokedexContext context)
        {
            var pokemon = context.TrainerPokemonMap.AsNoTracking()
                .Where(x=> x.TrainerId == trainer.Id)
                .Join(context.Pokemon, map => map.PokemonId, p => p.Id, (map,p) => p).Include(x => x.PokemonTypes)
                .Select(x=> PokemonController.PokemonToDTO(x, context)).ToList();

            return new TrainerDTO
            {
                Name = trainer.TrainerName,
                Email = trainer.Email,
                ContactNumber = trainer.ContactNumber,
                PokemonRoster = pokemon
            };
        }
    }
}