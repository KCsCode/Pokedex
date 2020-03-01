using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class ItemPocketNames
    {
        public long ItemPocketId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }

        public virtual ItemPockets ItemPocket { get; set; }
        public virtual Languages LocalLanguage { get; set; }
    }
}
