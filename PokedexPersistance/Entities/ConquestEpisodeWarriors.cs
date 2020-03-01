using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class ConquestEpisodeWarriors
    {
        public long EpisodeId { get; set; }
        public long WarriorId { get; set; }

        public virtual ConquestEpisodes Episode { get; set; }
        public virtual ConquestWarriors Warrior { get; set; }
    }
}
