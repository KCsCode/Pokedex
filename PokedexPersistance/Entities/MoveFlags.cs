using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class MoveFlags
    {
        public MoveFlags()
        {
            MoveFlagMap = new HashSet<MoveFlagMap>();
            MoveFlagProse = new HashSet<MoveFlagProse>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<MoveFlagMap> MoveFlagMap { get; set; }
        public virtual ICollection<MoveFlagProse> MoveFlagProse { get; set; }
    }
}
