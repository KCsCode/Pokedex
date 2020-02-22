using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class Experience
    {
        public long GrowthRateId { get; set; }
        public long Level { get; set; }
        public long Experience1 { get; set; }

        public virtual GrowthRates GrowthRate { get; set; }
    }
}
