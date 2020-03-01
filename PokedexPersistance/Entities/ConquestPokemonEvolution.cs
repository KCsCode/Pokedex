using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class ConquestPokemonEvolution
    {
        public long EvolvedSpeciesId { get; set; }
        public long? RequiredStatId { get; set; }
        public long? MinimumStat { get; set; }
        public long? MinimumLink { get; set; }
        public long? KingdomId { get; set; }
        public long? WarriorGenderId { get; set; }
        public long? ItemId { get; set; }
        public byte[] RecruitingKoRequired { get; set; }

        public virtual PokemonSpecies EvolvedSpecies { get; set; }
        public virtual Items Item { get; set; }
        public virtual ConquestKingdoms Kingdom { get; set; }
        public virtual ConquestStats RequiredStat { get; set; }
        public virtual Genders WarriorGender { get; set; }
    }
}
