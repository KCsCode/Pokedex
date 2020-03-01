using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class Pokemon
    {
        public Pokemon()
        {
            Encounters = new HashSet<Encounters>();
            PokemonAbilities = new HashSet<PokemonAbilities>();
            PokemonForms = new HashSet<PokemonForms>();
            PokemonGameIndices = new HashSet<PokemonGameIndices>();
            PokemonItems = new HashSet<PokemonItems>();
            PokemonMoves = new HashSet<PokemonMoves>();
            PokemonStats = new HashSet<PokemonStats>();
            PokemonTypes = new HashSet<PokemonTypes>();
            TrainerPokemonMap = new HashSet<TrainerPokemonMap>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }
        public long? SpeciesId { get; set; }
        public long Height { get; set; }
        public long Weight { get; set; }
        public long BaseExperience { get; set; }
        public long Order { get; set; }
        public byte[] IsDefault { get; set; }

        public virtual PokemonSpecies Species { get; set; }
        public virtual ICollection<Encounters> Encounters { get; set; }
        public virtual ICollection<PokemonAbilities> PokemonAbilities { get; set; }
        public virtual ICollection<PokemonForms> PokemonForms { get; set; }
        public virtual ICollection<PokemonGameIndices> PokemonGameIndices { get; set; }
        public virtual ICollection<PokemonItems> PokemonItems { get; set; }
        public virtual ICollection<PokemonMoves> PokemonMoves { get; set; }
        public virtual ICollection<PokemonStats> PokemonStats { get; set; }
        public virtual ICollection<PokemonTypes> PokemonTypes { get; set; }
        public virtual ICollection<TrainerPokemonMap> TrainerPokemonMap { get; set; }
    }
}
