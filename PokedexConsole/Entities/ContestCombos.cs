using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class ContestCombos
    {
        public long FirstMoveId { get; set; }
        public long SecondMoveId { get; set; }

        public virtual Moves FirstMove { get; set; }
        public virtual Moves SecondMove { get; set; }
    }
}
