using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class Moves
    {
        public Moves()
        {
            ConquestPokemonMoves = new HashSet<ConquestPokemonMoves>();
            ContestCombosFirstMove = new HashSet<ContestCombos>();
            ContestCombosSecondMove = new HashSet<ContestCombos>();
            Machines = new HashSet<Machines>();
            MoveChangelog = new HashSet<MoveChangelog>();
            MoveFlagMap = new HashSet<MoveFlagMap>();
            MoveFlavorSummaries = new HashSet<MoveFlavorSummaries>();
            MoveFlavorText = new HashSet<MoveFlavorText>();
            MoveMetaStatChanges = new HashSet<MoveMetaStatChanges>();
            MoveNames = new HashSet<MoveNames>();
            PokemonEvolution = new HashSet<PokemonEvolution>();
            PokemonMoves = new HashSet<PokemonMoves>();
            SuperContestCombosFirstMove = new HashSet<SuperContestCombos>();
            SuperContestCombosSecondMove = new HashSet<SuperContestCombos>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }
        public long GenerationId { get; set; }
        public long TypeId { get; set; }
        public long? Power { get; set; }
        public long? Pp { get; set; }
        public long? Accuracy { get; set; }
        public long Priority { get; set; }
        public long TargetId { get; set; }
        public long DamageClassId { get; set; }
        public long EffectId { get; set; }
        public long? EffectChance { get; set; }
        public long? ContestTypeId { get; set; }
        public long? ContestEffectId { get; set; }
        public long? SuperContestEffectId { get; set; }

        public virtual ContestEffects ContestEffect { get; set; }
        public virtual ContestTypes ContestType { get; set; }
        public virtual MoveDamageClasses DamageClass { get; set; }
        public virtual MoveEffects Effect { get; set; }
        public virtual Generations Generation { get; set; }
        public virtual SuperContestEffects SuperContestEffect { get; set; }
        public virtual MoveTargets Target { get; set; }
        public virtual Types Type { get; set; }
        public virtual ConquestMoveData ConquestMoveData { get; set; }
        public virtual MoveMeta MoveMeta { get; set; }
        public virtual ICollection<ConquestPokemonMoves> ConquestPokemonMoves { get; set; }
        public virtual ICollection<ContestCombos> ContestCombosFirstMove { get; set; }
        public virtual ICollection<ContestCombos> ContestCombosSecondMove { get; set; }
        public virtual ICollection<Machines> Machines { get; set; }
        public virtual ICollection<MoveChangelog> MoveChangelog { get; set; }
        public virtual ICollection<MoveFlagMap> MoveFlagMap { get; set; }
        public virtual ICollection<MoveFlavorSummaries> MoveFlavorSummaries { get; set; }
        public virtual ICollection<MoveFlavorText> MoveFlavorText { get; set; }
        public virtual ICollection<MoveMetaStatChanges> MoveMetaStatChanges { get; set; }
        public virtual ICollection<MoveNames> MoveNames { get; set; }
        public virtual ICollection<PokemonEvolution> PokemonEvolution { get; set; }
        public virtual ICollection<PokemonMoves> PokemonMoves { get; set; }
        public virtual ICollection<SuperContestCombos> SuperContestCombosFirstMove { get; set; }
        public virtual ICollection<SuperContestCombos> SuperContestCombosSecondMove { get; set; }
    }
}
