using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class Types
    {
        public Types()
        {
            Berries = new HashSet<Berries>();
            ConquestKingdoms = new HashSet<ConquestKingdoms>();
            ConquestWarriorSpecialties = new HashSet<ConquestWarriorSpecialties>();
            ConquestWarriorTransformation = new HashSet<ConquestWarriorTransformation>();
            MoveChangelog = new HashSet<MoveChangelog>();
            Moves = new HashSet<Moves>();
            PokemonEvolutionKnownMoveType = new HashSet<PokemonEvolution>();
            PokemonEvolutionPartyType = new HashSet<PokemonEvolution>();
            PokemonTypes = new HashSet<PokemonTypes>();
            TypeEfficacyDamageType = new HashSet<TypeEfficacy>();
            TypeEfficacyTargetType = new HashSet<TypeEfficacy>();
            TypeGameIndices = new HashSet<TypeGameIndices>();
            TypeNames = new HashSet<TypeNames>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }
        public long GenerationId { get; set; }
        public long? DamageClassId { get; set; }

        public virtual MoveDamageClasses DamageClass { get; set; }
        public virtual Generations Generation { get; set; }
        public virtual ICollection<Berries> Berries { get; set; }
        public virtual ICollection<ConquestKingdoms> ConquestKingdoms { get; set; }
        public virtual ICollection<ConquestWarriorSpecialties> ConquestWarriorSpecialties { get; set; }
        public virtual ICollection<ConquestWarriorTransformation> ConquestWarriorTransformation { get; set; }
        public virtual ICollection<MoveChangelog> MoveChangelog { get; set; }
        public virtual ICollection<Moves> Moves { get; set; }
        public virtual ICollection<PokemonEvolution> PokemonEvolutionKnownMoveType { get; set; }
        public virtual ICollection<PokemonEvolution> PokemonEvolutionPartyType { get; set; }
        public virtual ICollection<PokemonTypes> PokemonTypes { get; set; }
        public virtual ICollection<TypeEfficacy> TypeEfficacyDamageType { get; set; }
        public virtual ICollection<TypeEfficacy> TypeEfficacyTargetType { get; set; }
        public virtual ICollection<TypeGameIndices> TypeGameIndices { get; set; }
        public virtual ICollection<TypeNames> TypeNames { get; set; }
    }
}
