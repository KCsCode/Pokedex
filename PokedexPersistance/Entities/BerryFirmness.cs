using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class BerryFirmness
    {
        public BerryFirmness()
        {
            Berries = new HashSet<Berries>();
            BerryFirmnessNames = new HashSet<BerryFirmnessNames>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<Berries> Berries { get; set; }
        public virtual ICollection<BerryFirmnessNames> BerryFirmnessNames { get; set; }
    }
}
