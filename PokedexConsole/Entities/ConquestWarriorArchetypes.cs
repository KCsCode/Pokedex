using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class ConquestWarriorArchetypes
    {
        public ConquestWarriorArchetypes()
        {
            ConquestWarriors = new HashSet<ConquestWarriors>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<ConquestWarriors> ConquestWarriors { get; set; }
    }
}
