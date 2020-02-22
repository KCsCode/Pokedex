using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class ConquestEpisodeNames
    {
        public long EpisodeId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }

        public virtual ConquestEpisodes Episode { get; set; }
        public virtual Languages LocalLanguage { get; set; }
    }
}
