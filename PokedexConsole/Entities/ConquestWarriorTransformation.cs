using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class ConquestWarriorTransformation
    {
        public ConquestWarriorTransformation()
        {
            ConquestTransformationPokemon = new HashSet<ConquestTransformationPokemon>();
            ConquestTransformationWarriors = new HashSet<ConquestTransformationWarriors>();
        }

        public long TransformedWarriorRankId { get; set; }
        public byte[] IsAutomatic { get; set; }
        public long? RequiredLink { get; set; }
        public long? CompletedEpisodeId { get; set; }
        public long? CurrentEpisodeId { get; set; }
        public long? DistantWarriorId { get; set; }
        public long? FemaleWarlordCount { get; set; }
        public long? PokemonCount { get; set; }
        public long? CollectionTypeId { get; set; }
        public long? WarriorCount { get; set; }

        public virtual Types CollectionType { get; set; }
        public virtual ConquestEpisodes CompletedEpisode { get; set; }
        public virtual ConquestEpisodes CurrentEpisode { get; set; }
        public virtual ConquestWarriors DistantWarrior { get; set; }
        public virtual ConquestWarriorRanks TransformedWarriorRank { get; set; }
        public virtual ICollection<ConquestTransformationPokemon> ConquestTransformationPokemon { get; set; }
        public virtual ICollection<ConquestTransformationWarriors> ConquestTransformationWarriors { get; set; }
    }
}
