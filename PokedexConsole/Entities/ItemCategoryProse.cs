using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class ItemCategoryProse
    {
        public long ItemCategoryId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }

        public virtual ItemCategories ItemCategory { get; set; }
        public virtual Languages LocalLanguage { get; set; }
    }
}
