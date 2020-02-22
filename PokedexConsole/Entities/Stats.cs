using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class Stats
    {
        public Stats()
        {
            Characteristics = new HashSet<Characteristics>();
            MoveMetaStatChanges = new HashSet<MoveMetaStatChanges>();
            NaturesDecreasedStat = new HashSet<Natures>();
            NaturesIncreasedStat = new HashSet<Natures>();
            PokemonStats = new HashSet<PokemonStats>();
            StatNames = new HashSet<StatNames>();
        }

        public long Id { get; set; }
        public long? DamageClassId { get; set; }
        public string Identifier { get; set; }
        public byte[] IsBattleOnly { get; set; }
        public long? GameIndex { get; set; }

        public virtual MoveDamageClasses DamageClass { get; set; }
        public virtual ICollection<Characteristics> Characteristics { get; set; }
        public virtual ICollection<MoveMetaStatChanges> MoveMetaStatChanges { get; set; }
        public virtual ICollection<Natures> NaturesDecreasedStat { get; set; }
        public virtual ICollection<Natures> NaturesIncreasedStat { get; set; }
        public virtual ICollection<PokemonStats> PokemonStats { get; set; }
        public virtual ICollection<StatNames> StatNames { get; set; }
    }
}
