using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class ItemFlingEffects
    {
        public ItemFlingEffects()
        {
            ItemFlingEffectProse = new HashSet<ItemFlingEffectProse>();
            Items = new HashSet<Items>();
        }

        public long Id { get; set; }

        public virtual ICollection<ItemFlingEffectProse> ItemFlingEffectProse { get; set; }
        public virtual ICollection<Items> Items { get; set; }
    }
}
