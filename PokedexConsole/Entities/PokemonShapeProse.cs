using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class PokemonShapeProse
    {
        public long PokemonShapeId { get; set; }
        public long LocalLanguageId { get; set; }
        public string Name { get; set; }
        public string AwesomeName { get; set; }
        public string Description { get; set; }

        public virtual Languages LocalLanguage { get; set; }
        public virtual PokemonShapes PokemonShape { get; set; }
    }
}
