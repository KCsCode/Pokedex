using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class ItemFlags
    {
        public ItemFlags()
        {
            ItemFlagMap = new HashSet<ItemFlagMap>();
            ItemFlagProse = new HashSet<ItemFlagProse>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<ItemFlagMap> ItemFlagMap { get; set; }
        public virtual ICollection<ItemFlagProse> ItemFlagProse { get; set; }
    }
}
