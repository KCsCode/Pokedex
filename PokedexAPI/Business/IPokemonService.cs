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
        /// 
        /// </summary>
        PokemonResponseDTO GetPokemonById(RequestByIdDTO request);

        /// <summary>
        /// 
        /// </summary>
        IEnumerable<PokemonResponseDTO> GetPokemonByTypeId(RequestByIdDTO request);

        /// <summary>
        /// 
        /// </summary>
        List<TypeResponseDTO> GetTypes();

        /// <summary>
        /// 
        /// </summary>
        IEnumerable<TrainerResponseDTO> GetAllTrainers();

        /// <summary>
        /// 
        /// </summary>
        TrainerResponseDTO GetTrainerById(RequestByIdDTO request);

        /// <summary>
        /// 
        /// </summary>
        string RegisterPokemonToTrainer(TrainerPokemonRequestDTO request);

        /// <summary>
        /// 
        /// </summary>
        string UnregisterPokemonToTrainer(TrainerPokemonRequestDTO request);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string CreateTrainer(TrainerRequestDTO request);

        /// <summary>
        /// 
        /// </summary>
        string UpdateTrainer(TrainerRequestDTO request);

        /// <summary>
        /// 
        /// </summary>
        string RemoveTrainer(RequestByIdDTO request);

    }
}
