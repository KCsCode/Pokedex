using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class ConquestMoveRanges
    {
        public ConquestMoveRanges()
        {
            ConquestMoveData = new HashSet<ConquestMoveData>();
            ConquestMoveRangeProse = new HashSet<ConquestMoveRangeProse>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }
        public long Targets { get; set; }

        public virtual ICollection<ConquestMoveData> ConquestMoveData { get; set; }
        public virtual ICollection<ConquestMoveRangeProse> ConquestMoveRangeProse { get; set; }
    }
}
