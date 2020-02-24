using System;
using PokedexConsole.Entities;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace PokedexConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (PokedexContext context = new PokedexContext())
            {
               Console.WriteLine("Querying for pokemon");
               IQueryable<Pokemon> pokemon = context.Pokemon.Include(m => m.PokemonMoves)
                   .Where(p => p.Id< 10);

                Console.WriteLine("Print pokelist: ");
                List<Pokemon> plist = pokemon.ToList();
                plist.ForEach(p => Console.WriteLine(p.Identifier));
                Console.WriteLine("End");

            }

        }
    }
}
