using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class ItemFlagProse
    {
        public long ItemFlagId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ItemFlags ItemFlag { get; set; }
        public virtual Languages LocalLanguage { get; set; }
    }
}
