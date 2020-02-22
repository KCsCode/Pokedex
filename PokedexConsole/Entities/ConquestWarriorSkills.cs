using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class ConquestWarriorSkills
    {
        public ConquestWarriorSkills()
        {
            ConquestWarriorRanks = new HashSet<ConquestWarriorRanks>();
            ConquestWarriorSkillNames = new HashSet<ConquestWarriorSkillNames>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<ConquestWarriorRanks> ConquestWarriorRanks { get; set; }
        public virtual ICollection<ConquestWarriorSkillNames> ConquestWarriorSkillNames { get; set; }
    }
}
