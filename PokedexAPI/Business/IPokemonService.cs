using Microsoft.AspNetCore.Mvc;
using PokedexDTOs.RequestDTO;
using PokedexDTOs.ResponseDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokedexAPI.Business
{
    public interface IPokemonService
    {
        /// <summary>
        /// Returns single pokemon matching the id provided in the request.
        /// </summary>
        PokemonResponseDTO GetPokemonById(RequestByIdDTO request);

        /// <summary>
        /// Returns all pokemon matching the id provided in the request.
        /// </summary>
        IEnumerable<PokemonResponseDTO> GetPokemonByTypeId(RequestByIdDTO request);

        /// <summary>
        /// Returns all pokemon types.
        /// </summary>
        List<TypeResponseDTO> GetTypes();

        /// <summary>
        /// Returns all trainers.
        /// </summary>
        IEnumerable<TrainerResponseDTO> GetAllTrainers();

        /// <summary>
        /// Returns single trainer matching the id provided in the request.
        /// </summary>
        TrainerResponseDTO GetTrainerById(RequestByIdDTO request);

        /// <summary>
        /// Associates pokemon to trainer. Will return error messge if failure occurs.
        /// </summary>
        string RegisterPokemonToTrainer(TrainerPokemonRequestDTO request);

        /// <summary>
        /// Unassociates pokemon from trainer. Will return error messge if failure occurs.
        /// </summary>
        string UnregisterPokemonToTrainer(TrainerPokemonRequestDTO request);

        /// <summary>
        /// Creates new trainer record. Id will be auto incremented. Will return error messge if failure occurs.
        /// </summary>
        /// <returns></returns>
        string CreateTrainer(TrainerRequestDTO request);

        /// <summary>
        /// Updates existing trainer record matching the id provided in the request.. Will return error messge if failure occurs.
        /// </summary>
        string UpdateTrainer(TrainerRequestDTO request);

        /// <summary>
        /// Removes existing trainer record matching the id provided in the request.. Will return error messge if failure occurs.
        /// </summary>
        string RemoveTrainer(RequestByIdDTO request);

    }
}
