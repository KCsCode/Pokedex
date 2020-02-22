using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class ConquestWarriorNames
    {
        public long WarriorId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }

        public virtual Languages LocalLanguage { get; set; }
        public virtual ConquestWarriors Warrior { get; set; }
    }
}
