using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class ConquestWarriorRanks
    {
        public ConquestWarriorRanks()
        {
            ConquestMaxLinks = new HashSet<ConquestMaxLinks>();
            ConquestWarriorRankStatMap = new HashSet<ConquestWarriorRankStatMap>();
        }

        public long Id { get; set; }
        public long WarriorId { get; set; }
        public long Rank { get; set; }
        public long SkillId { get; set; }

        public virtual ConquestWarriorSkills Skill { get; set; }
        public virtual ConquestWarriors Warrior { get; set; }
        public virtual ConquestWarriorTransformation ConquestWarriorTransformation { get; set; }
        public virtual ICollection<ConquestMaxLinks> ConquestMaxLinks { get; set; }
        public virtual ICollection<ConquestWarriorRankStatMap> ConquestWarriorRankStatMap { get; set; }
    }
}
