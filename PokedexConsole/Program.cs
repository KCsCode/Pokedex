using System;
using PokedexConsole.Entities;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace PokedexConsole
{
    public class Car
    {
        public string BrandName { get; set; }
        public List<string> Models { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            using (PokedexContext context = new PokedexContext())
            {
                Console.WriteLine("Querying for pokemon");

                ////Include
                //IQueryable<Pokemon> pokemon = context.Pokemon.Include(m => m.PokemonTypes)
                //    .Where(p => p.Id< 10);

                //Console.WriteLine("Print pokelist: ");
                //List<Pokemon> plist = pokemon.ToList();
                //plist.ForEach(p => {
                //    ;
                //    Console.Write("Pokemon {0} is type: ", p.Identifier);
                //    Console.WriteLine(String.Join(",", p.PokemonTypes.Select(x => x.TypeId).ToList()));
                //});

                ////LINQ
                ////Query
                //List<String> result = (from p in context.Pokemon
                //              where p.PokemonTypes.Any(t => t.TypeId == 12) select p.Identifier
                //              ).ToList();
                //Console.WriteLine("Grass pokemon:");
                //result.ForEach(r => Console.WriteLine(r));

                ////Fluent
                //var result2 = context.Pokemon.Where(p => p.PokemonTypes.Any(t => t.TypeId == 12)).ToList();
                //Console.WriteLine("Grass pokemon:");
                //result2.ForEach(r => Console.WriteLine(r));

                //var types = context.Pokemon.Take(3).SelectMany(p => p.PokemonTypes).Select(p => p.TypeId).ToList();
                //types.ForEach(r => Console.WriteLine(r));

                //Get all Generation 1 Types
                var types = context.Types.Where(t => t.GenerationId == 1);
                types.ToList().ForEach(r => Console.WriteLine((r.Identifier)));

                //Get all Pokemon Where Type = 12 (Grass)
                var result2 = context.Pokemon.Where(p => p.PokemonTypes.Any(t => t.TypeId == 12));
                Console.WriteLine("Grass pokemon:");
                result2.ToList().ForEach(r => Console.WriteLine(r.Identifier));


                //var result = context.Pokemon.Select(p => new { name = p.Identifier, types = p.PokemonTypes.Count() });
                //result.ToList().ForEach(r => Console.WriteLine(r));
                ////x => x.PokemonTypes).Select(p => p).ToList() ;
                ////Console.WriteLine(result);
                //Console.WriteLine("Grass pokemon:");
                


                Console.WriteLine("End");
                
            }

        }
    }
}
