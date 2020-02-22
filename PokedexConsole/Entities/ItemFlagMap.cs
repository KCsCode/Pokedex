using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class ItemFlagMap
    {
        public long ItemId { get; set; }
        public long ItemFlagId { get; set; }

        public virtual Items Item { get; set; }
        public virtual ItemFlags ItemFlag { get; set; }
    }
}
