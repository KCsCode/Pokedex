using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class ContestTypeNames
    {
        public long ContestTypeId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }
        public string Flavor { get; set; }
        public string Color { get; set; }

        public virtual ContestTypes ContestType { get; set; }
        public virtual Languages LocalLanguage { get; set; }
    }
}
