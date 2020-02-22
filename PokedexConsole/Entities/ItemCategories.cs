using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class ItemCategories
    {
        public ItemCategories()
        {
            ItemCategoryProse = new HashSet<ItemCategoryProse>();
            Items = new HashSet<Items>();
        }

        public long Id { get; set; }
        public long PocketId { get; set; }
        public string Identifier { get; set; }

        public virtual ItemPockets Pocket { get; set; }
        public virtual ICollection<ItemCategoryProse> ItemCategoryProse { get; set; }
        public virtual ICollection<Items> Items { get; set; }
    }
}
