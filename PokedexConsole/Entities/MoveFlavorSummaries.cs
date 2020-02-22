using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class MoveFlavorSummaries
    {
        public long MoveId { get; set; }
        public long LocalLanguageId { get; set; }
        public string FlavorSummary { get; set; }

        public virtual Languages LocalLanguage { get; set; }
        public virtual Moves Move { get; set; }
    }
}
