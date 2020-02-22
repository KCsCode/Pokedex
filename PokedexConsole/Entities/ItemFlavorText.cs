using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class ItemFlavorText
    {
        public long ItemId { get; set; }
        public long VersionGroupId { get; set; }
        public long LanguageId { get; set; }
        public string FlavorText { get; set; }

        public virtual Items Item { get; set; }
        public virtual Languages Language { get; set; }
        public virtual VersionGroups VersionGroup { get; set; }
    }
}
