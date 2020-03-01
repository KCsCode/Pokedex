using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class Trainer
    {
        public long Id { get; set; }
        public string TrainerName { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
    }
}
