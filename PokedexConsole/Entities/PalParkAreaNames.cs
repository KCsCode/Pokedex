using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class PalParkAreaNames
    {
        public long PalParkAreaId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }

        public virtual Languages LocalLanguage { get; set; }
        public virtual PalParkAreas PalParkArea { get; set; }
    }
}
