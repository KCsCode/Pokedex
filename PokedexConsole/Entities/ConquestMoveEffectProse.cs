using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class ConquestMoveEffectProse
    {
        public long ConquestMoveEffectId { get; set; }
        public long LocalLanguageId { get; set; }
        public string ShortEffect { get; set; }
        public string Effect { get; set; }

        public virtual ConquestMoveEffects ConquestMoveEffect { get; set; }
        public virtual Languages LocalLanguage { get; set; }
    }
}
