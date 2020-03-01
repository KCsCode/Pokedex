using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class VersionGroupRegions
    {
        public long VersionGroupId { get; set; }
        public long RegionId { get; set; }

        public virtual Regions Region { get; set; }
        public virtual VersionGroups VersionGroup { get; set; }
    }
}
