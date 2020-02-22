using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class SuperContestCombos
    {
        public long FirstMoveId { get; set; }
        public long SecondMoveId { get; set; }

        public virtual Moves FirstMove { get; set; }
        public virtual Moves SecondMove { get; set; }
    }
}
