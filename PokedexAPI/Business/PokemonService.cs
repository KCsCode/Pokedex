using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PokedexDTOs.RequestDTO;
using PokedexDTOs.ResponseDTO;
using PokedexPersistance.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PokedexAPI.Business
{
    public class PokemonService : IPokemonService
    {
        #region Fields

        private readonly PokedexContext _context;

        #endregion

        #region Constructor

        /// <summary>
        /// 
        /// </summary>
        public PokemonService(PokedexContext context)
        {
            _context = context;
        }

        #endregion

        #region Public Methods

        /// <inheritdoc />
        public PokemonResponseDTO GetPokemonById(RequestByIdDTO request)
        {
            PokemonResponseDTO response = null;

            Pokemon pokemon = _context.Pokemon.AsNoTracking()
                .Include(x => x.PokemonTypes).FirstOrDefault(x => x.Id == request.Id);
            if (pokemon != null)
            {
                response = PokemonToDTO(pokemon);
            }

            return response;
        }

        /// <inheritdoc />
        public IEnumerable<PokemonResponseDTO> GetPokemonByTypeId(RequestByIdDTO request)
        {
            List<PokemonResponseDTO> response = new List<PokemonResponseDTO>();

            Types typeId = _context.Types.AsNoTracking().FirstOrDefault(x => x.Id == request.Id);
            if (typeId != null)
            {
                IEnumerable<Pokemon> pokemon = _context.Pokemon.AsNoTracking()
                                           .Include(x => x.PokemonTypes)
                                           .Where(x => x.PokemonTypes.Any(y => y.TypeId == request.Id));
                foreach (Pokemon p in pokemon)
                {
                    response.Add(PokemonToDTO(p));
                }
            }

            return response;
        }

        public IEnumerable<TrainerResponseDTO> GetAllTrainers()
        {
            List<TrainerResponseDTO> response = new List<TrainerResponseDTO>();
            IEnumerable<Trainer> trainers =_context.Trainer.AsNoTracking();
            foreach (Trainer trainer in trainers)
            {
                response.Add(TrainerToDTO(trainer));
            }

            return response;
        }

        public TrainerResponseDTO GetTrainerById(RequestByIdDTO request)
        {
            TrainerResponseDTO response = null;

            Trainer trainer = _context.Trainer.AsNoTracking().FirstOrDefault(x => x.Id == request.Id);
            if (trainer != null)
            {
                response = TrainerToDTO(trainer);
            }

            return response;
        }

        /// <inheritdoc />
        public List<TypeResponseDTO> GetTypes()
        {
            List<TypeResponseDTO> response = new List<TypeResponseDTO>(); ;

            IEnumerable<Types> types = _context.Types.AsNoTracking();
            foreach (Types type in types)
            {
                response.Add(TypesToDTO(type));
            }

            return response;
        }

        /// <inheritdoc />
        public string RegisterPokemonToTrainer(TrainerPokemonRequestDTO request)
        {
            string error = null;
            Trainer trainer = null;
            trainer =_context.Trainer.AsNoTracking().FirstOrDefault(x => x.Id == request.TrainerId);

            if (trainer != null)
            {
                int pokemonRegisteredCount = _context.TrainerPokemonMap.AsNoTracking().Where(x => x.TrainerId == request.TrainerId).Count();
                if (pokemonRegisteredCount < 6)
                {
                    TrainerPokemonMap trainerPokemon = new TrainerPokemonMap
                    {
                        TrainerId = request.TrainerId,
                        PokemonId = request.PokemonId
                    };
                    _context.TrainerPokemonMap.Add(trainerPokemon);

                    if (_context.SaveChanges() != 1)
                    {
                        error = "Error saving changes.";
                    }
                }
                else {
                    error = "Trainer has too many pokemon. Unregister pokemon before registering more.";
                }
            }
            else 
            {
                error = "TrainerId does not exist.";
            }
            

            return error;
        }

        /// <inheritdoc />
        public string UnregisterPokemonToTrainer(TrainerPokemonRequestDTO request)
        {
            string error = null;

            Trainer trainer = _context.Trainer.AsNoTracking().FirstOrDefault(x => x.Id == request.TrainerId);
            if (trainer != null)
            {
                Pokemon pokemon = _context.Pokemon.AsNoTracking().FirstOrDefault(x => x.Id == request.PokemonId);
                if (pokemon != null)
                {
                    TrainerPokemonMap registeredPokemon = _context.TrainerPokemonMap
                        .FirstOrDefault(x => request.TrainerId == x.TrainerId && request.PokemonId == x.PokemonId);

                    if (registeredPokemon != null)
                    {
                        _context.Remove(pokemon);
                        if(_context.SaveChanges() != 1)
                        {
                            error = "Error saving changes.";
                        }

                    }
                    else
                    {
                        error = "Pokemon was not registered to Trainer.";
                    }
                }
                else
                { 
                    error = "PokemonId does not exist.";
                }

            }
            else
            {
                error = "TrainerId does not exist.";
            }

            return error;
        }

        /// <inheritdoc />
        public string CreateTrainer(TrainerRequestDTO request)
        {
            string error = null;
            
            Trainer newTrainer = new Trainer
            {
                TrainerName = request.Name,
                Email = request.Email,
                ContactNumber = request.ContactNumber
            };
            _context.Trainer.Add(newTrainer);
            
            if (_context.SaveChanges() != 1)
            {
                error = "Error saving changes.";
            }

            return error;
        }

        /// <inheritdoc />
        public string UpdateTrainer(TrainerRequestDTO request)
        {
            string error = null;

            Trainer trainer = _context.Trainer.FirstOrDefault(x => x.Id == request.Id);
            if (trainer != null)
            {
                trainer.TrainerName = request.Name;
                trainer.Email = request.Email;
                trainer.ContactNumber = request.ContactNumber;

                if (_context.SaveChanges() != 1)
                {
                    error = "Error saving changes.";
                }
            }
            else
            {
                error = "TrainerId does not exist.";
            }
            return error;
        }

        /// <inheritdoc />
        public string RemoveTrainer(RequestByIdDTO request)
        {
            string error = null;

            Trainer trainer = _context.Trainer.FirstOrDefault(x => x.Id == request.Id);
            if (trainer != null)
            {
                _context.Remove(trainer);
                if (_context.SaveChanges() != 1)
                {
                    error = "Error saving changes.";
                }
            }
            else
            {
                error = "TrainerId does not exist.";
            }
            return error;
        }

        #endregion

        #region Private Methods

        private PokemonResponseDTO PokemonToDTO(Pokemon pokemon)
        {
            List<TypeResponseDTO> types = new List<TypeResponseDTO>();

            foreach (PokemonTypes type in pokemon.PokemonTypes ?? Enumerable.Empty<PokemonTypes>())
            {
                types.Add(new TypeResponseDTO()
                {
                    Name = _context.Types.AsNoTracking().FirstOrDefault(x => x.Id == type.TypeId)?.Identifier,
                    Id = type.TypeId
                });
            }

            return new PokemonResponseDTO
            {
                PokemonName = pokemon.Identifier,
                PokedexId = pokemon.SpeciesId,
                Height = pokemon.Height,
                Weight = pokemon.Weight,
                BaseExperience = pokemon.BaseExperience,
                Types = types
            };
        }

        private TypeResponseDTO TypesToDTO(Types type)
        {
            return new TypeResponseDTO
            {
                Id = type.Id,
                Name = type.Identifier
            };
        }

        private TrainerResponseDTO TrainerToDTO(Trainer trainer)
        {
            List<PokemonResponseDTO> registeredPokemon = new List<PokemonResponseDTO>();
            IEnumerable<Pokemon> pokemon = _context.TrainerPokemonMap.AsNoTracking()
                .Where(x => x.TrainerId == trainer.Id)
                .Join(_context.Pokemon, map => map.PokemonId, p => p.Id, (map, p) => p).Include(x => x.PokemonTypes);


            foreach(Pokemon p in pokemon)
            {
                registeredPokemon.Add(PokemonToDTO(p));
            };

            return new TrainerResponseDTO
            {
                Id = trainer.Id,
                Name = trainer.TrainerName,
                Email = trainer.Email,
                ContactNumber = trainer.ContactNumber,
                RegisteredPokemon = registeredPokemon
            };
        }
        #endregion
    }
}
