using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class PokemonEvolution
    {
        public long Id { get; set; }
        public long EvolvedSpeciesId { get; set; }
        public long EvolutionTriggerId { get; set; }
        public long? TriggerItemId { get; set; }
        public long? MinimumLevel { get; set; }
        public long? GenderId { get; set; }
        public long? LocationId { get; set; }
        public long? HeldItemId { get; set; }
        public string TimeOfDay { get; set; }
        public long? KnownMoveId { get; set; }
        public long? KnownMoveTypeId { get; set; }
        public long? MinimumHappiness { get; set; }
        public long? MinimumBeauty { get; set; }
        public long? MinimumAffection { get; set; }
        public long? RelativePhysicalStats { get; set; }
        public long? PartySpeciesId { get; set; }
        public long? PartyTypeId { get; set; }
        public long? TradeSpeciesId { get; set; }
        public byte[] NeedsOverworldRain { get; set; }
        public byte[] TurnUpsideDown { get; set; }

        public virtual EvolutionTriggers EvolutionTrigger { get; set; }
        public virtual PokemonSpecies EvolvedSpecies { get; set; }
        public virtual Genders Gender { get; set; }
        public virtual Items HeldItem { get; set; }
        public virtual Moves KnownMove { get; set; }
        public virtual Types KnownMoveType { get; set; }
        public virtual Locations Location { get; set; }
        public virtual PokemonSpecies PartySpecies { get; set; }
        public virtual Types PartyType { get; set; }
        public virtual PokemonSpecies TradeSpecies { get; set; }
        public virtual Items TriggerItem { get; set; }
    }
}
