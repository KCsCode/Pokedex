using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class Berries
    {
        public Berries()
        {
            BerryFlavors = new HashSet<BerryFlavors>();
        }

        public long Id { get; set; }
        public long ItemId { get; set; }
        public long FirmnessId { get; set; }
        public long? NaturalGiftPower { get; set; }
        public long? NaturalGiftTypeId { get; set; }
        public long Size { get; set; }
        public long MaxHarvest { get; set; }
        public long GrowthTime { get; set; }
        public long SoilDryness { get; set; }
        public long Smoothness { get; set; }

        public virtual BerryFirmness Firmness { get; set; }
        public virtual Items Item { get; set; }
        public virtual Types NaturalGiftType { get; set; }
        public virtual ICollection<BerryFlavors> BerryFlavors { get; set; }
    }
}
