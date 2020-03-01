using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class ItemGameIndices
    {
        public long ItemId { get; set; }
        public long GenerationId { get; set; }
        public long GameIndex { get; set; }

        public virtual Generations Generation { get; set; }
        public virtual Items Item { get; set; }
    }
}
