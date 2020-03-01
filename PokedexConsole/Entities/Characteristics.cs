using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class Characteristics
    {
        public Characteristics()
        {
            CharacteristicText = new HashSet<CharacteristicText>();
        }

        public long Id { get; set; }
        public long StatId { get; set; }
        public long GeneMod5 { get; set; }

        public virtual Stats Stat { get; set; }
        public virtual ICollection<CharacteristicText> CharacteristicText { get; set; }
    }
}
