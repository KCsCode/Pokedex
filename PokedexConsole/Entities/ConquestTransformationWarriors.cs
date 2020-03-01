using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class ConquestTransformationWarriors
    {
        public long TransformationId { get; set; }
        public long PresentWarriorId { get; set; }

        public virtual ConquestWarriors PresentWarrior { get; set; }
        public virtual ConquestWarriorTransformation Transformation { get; set; }
    }
}
