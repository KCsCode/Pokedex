using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class MoveBattleStyleProse
    {
        public long MoveBattleStyleId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }

        public virtual Languages LocalLanguage { get; set; }
        public virtual MoveBattleStyles MoveBattleStyle { get; set; }
    }
}
