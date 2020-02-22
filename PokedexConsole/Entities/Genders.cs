using System;
using System.Collections.Generic;

namespace PokedexConsole.Entities
{
    public partial class Genders
    {
        public Genders()
        {
            ConquestPokemonEvolution = new HashSet<ConquestPokemonEvolution>();
            ConquestWarriors = new HashSet<ConquestWarriors>();
            PokemonEvolution = new HashSet<PokemonEvolution>();
        }

        public long Id { get; set; }
        public string Identifier { get; set; }

        public virtual ICollection<ConquestPokemonEvolution> ConquestPokemonEvolution { get; set; }
        public virtual ICollection<ConquestWarriors> ConquestWarriors { get; set; }
        public virtual ICollection<PokemonEvolution> PokemonEvolution { get; set; }
    }
}
