using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class LocationNames
    {
        public long LocationId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }

        public virtual Languages LocalLanguage { get; set; }
        public virtual Locations Location { get; set; }
    }
}
