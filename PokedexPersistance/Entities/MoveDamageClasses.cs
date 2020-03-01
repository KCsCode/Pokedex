using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class MoveDamageClasses
    {
        public MoveDamageClasses()
        {
            MoveDamageClassProse = new HashSet<MoveDamageClassProse>();
            Moves = new HashSet<Moves>();
            Stats = new HashSet<Stats>();
            Types = new HashSet<Types>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<MoveDamageClassProse> MoveDamageClassProse { get; set; }
        public virtual ICollection<Moves> Moves { get; set; }
        public virtual ICollection<Stats> Stats { get; set; }
        public virtual ICollection<Types> Types { get; set; }
    }
}
