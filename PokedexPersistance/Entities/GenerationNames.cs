using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class GenerationNames
    {
        public long GenerationId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }

        public virtual Generations Generation { get; set; }
        public virtual Languages LocalLanguage { get; set; }
    }
}
