using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class PalParkAreas
    {
        public PalParkAreas()
        {
            PalPark = new HashSet<PalPark>();
            PalParkAreaNames = new HashSet<PalParkAreaNames>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<PalPark> PalPark { get; set; }
        public virtual ICollection<PalParkAreaNames> PalParkAreaNames { get; set; }
    }
}
