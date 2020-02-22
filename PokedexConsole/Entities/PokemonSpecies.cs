using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class PokemonSpecies
    {
        public PokemonSpecies()
        {
            ConquestMaxLinks = new HashSet<ConquestMaxLinks>();
            ConquestPokemonAbilities = new HashSet<ConquestPokemonAbilities>();
            ConquestPokemonStats = new HashSet<ConquestPokemonStats>();
            ConquestTransformationPokemon = new HashSet<ConquestTransformationPokemon>();
            InverseEvolvesFromSpecies = new HashSet<PokemonSpecies>();
            Pokemon = new HashSet<Pokemon>();
            PokemonDexNumbers = new HashSet<PokemonDexNumbers>();
            PokemonEggGroups = new HashSet<PokemonEggGroups>();
            PokemonEvolutionEvolvedSpecies = new HashSet<PokemonEvolution>();
            PokemonEvolutionPartySpecies = new HashSet<PokemonEvolution>();
            PokemonEvolutionTradeSpecies = new HashSet<PokemonEvolution>();
            PokemonSpeciesFlavorSummaries = new HashSet<PokemonSpeciesFlavorSummaries>();
            PokemonSpeciesFlavorText = new HashSet<PokemonSpeciesFlavorText>();
            PokemonSpeciesNames = new HashSet<PokemonSpeciesNames>();
            PokemonSpeciesProse = new HashSet<PokemonSpeciesProse>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }
        public long? GenerationId { get; set; }
        public long? EvolvesFromSpeciesId { get; set; }
        public long? EvolutionChainId { get; set; }
        public long ColorId { get; set; }
        public long ShapeId { get; set; }
        public long? HabitatId { get; set; }
        public long GenderRate { get; set; }
        public long CaptureRate { get; set; }
        public long BaseHappiness { get; set; }
        public byte[] IsBaby { get; set; }
        public long HatchCounter { get; set; }
        public byte[] HasGenderDifferences { get; set; }
        public long GrowthRateId { get; set; }
        public byte[] FormsSwitchable { get; set; }
        public long Order { get; set; }
        public long? ConquestOrder { get; set; }

        public virtual PokemonColors Color { get; set; }
        public virtual EvolutionChains EvolutionChain { get; set; }
        public virtual PokemonSpecies EvolvesFromSpecies { get; set; }
        public virtual Generations Generation { get; set; }
        public virtual GrowthRates GrowthRate { get; set; }
        public virtual PokemonHabitats Habitat { get; set; }
        public virtual PokemonShapes Shape { get; set; }
        public virtual ConquestPokemonEvolution ConquestPokemonEvolution { get; set; }
        public virtual ConquestPokemonMoves ConquestPokemonMoves { get; set; }
        public virtual PalPark PalPark { get; set; }
        public virtual ICollection<ConquestMaxLinks> ConquestMaxLinks { get; set; }
        public virtual ICollection<ConquestPokemonAbilities> ConquestPokemonAbilities { get; set; }
        public virtual ICollection<ConquestPokemonStats> ConquestPokemonStats { get; set; }
        public virtual ICollection<ConquestTransformationPokemon> ConquestTransformationPokemon { get; set; }
        public virtual ICollection<PokemonSpecies> InverseEvolvesFromSpecies { get; set; }
        public virtual ICollection<Pokemon> Pokemon { get; set; }
        public virtual ICollection<PokemonDexNumbers> PokemonDexNumbers { get; set; }
        public virtual ICollection<PokemonEggGroups> PokemonEggGroups { get; set; }
        public virtual ICollection<PokemonEvolution> PokemonEvolutionEvolvedSpecies { get; set; }
        public virtual ICollection<PokemonEvolution> PokemonEvolutionPartySpecies { get; set; }
        public virtual ICollection<PokemonEvolution> PokemonEvolutionTradeSpecies { get; set; }
        public virtual ICollection<PokemonSpeciesFlavorSummaries> PokemonSpeciesFlavorSummaries { get; set; }
        public virtual ICollection<PokemonSpeciesFlavorText> PokemonSpeciesFlavorText { get; set; }
        public virtual ICollection<PokemonSpeciesNames> PokemonSpeciesNames { get; set; }
        public virtual ICollection<PokemonSpeciesProse> PokemonSpeciesProse { get; set; }
    }
}
