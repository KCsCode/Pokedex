using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class Versions
    {
        public Versions()
        {
            Encounters = new HashSet<Encounters>();
            LocationAreaEncounterRates = new HashSet<LocationAreaEncounterRates>();
            PokemonGameIndices = new HashSet<PokemonGameIndices>();
            PokemonItems = new HashSet<PokemonItems>();
            PokemonSpeciesFlavorText = new HashSet<PokemonSpeciesFlavorText>();
            VersionNames = new HashSet<VersionNames>();
        }

        public long Id { get; set; }
        public long VersionGroupId { get; set; }
        public string Identifier { get; set; }

        public virtual VersionGroups VersionGroup { get; set; }
        public virtual ICollection<Encounters> Encounters { get; set; }
        public virtual ICollection<LocationAreaEncounterRates> LocationAreaEncounterRates { get; set; }
        public virtual ICollection<PokemonGameIndices> PokemonGameIndices { get; set; }
        public virtual ICollection<PokemonItems> PokemonItems { get; set; }
        public virtual ICollection<PokemonSpeciesFlavorText> PokemonSpeciesFlavorText { get; set; }
        public virtual ICollection<VersionNames> VersionNames { get; set; }
    }
}
