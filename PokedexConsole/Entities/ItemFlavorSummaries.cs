using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class ItemFlavorSummaries
    {
        public long ItemId { get; set; }
        public long LocalLanguageId { get; set; }
        public string FlavorSummary { get; set; }

        public virtual Items Item { get; set; }
        public virtual Languages LocalLanguage { get; set; }
    }
}
