using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class Machines
    {
        public long MachineNumber { get; set; }
        public long VersionGroupId { get; set; }
        public long ItemId { get; set; }
        public long MoveId { get; set; }

        public virtual Items Item { get; set; }
        public virtual Moves Move { get; set; }
        public virtual VersionGroups VersionGroup { get; set; }
    }
}
