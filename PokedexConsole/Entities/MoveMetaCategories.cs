using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class MoveMetaCategories
    {
        public MoveMetaCategories()
        {
            MoveMeta = new HashSet<MoveMeta>();
            MoveMetaCategoryProse = new HashSet<MoveMetaCategoryProse>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<MoveMeta> MoveMeta { get; set; }
        public virtual ICollection<MoveMetaCategoryProse> MoveMetaCategoryProse { get; set; }
    }
}
