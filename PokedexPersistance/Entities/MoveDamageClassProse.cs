using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class MoveDamageClassProse
    {
        public long MoveDamageClassId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual Languages LocalLanguage { get; set; }
        public virtual MoveDamageClasses MoveDamageClass { get; set; }
    }
}
