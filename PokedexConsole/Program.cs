using System;
using PokedexConsole.Entities;
using System.Linq;

namespace PokedexConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (PokedexContext context = new PokedexContext())
            {
                Console.WriteLine("Querying for berries");
                IQueryable<Berries> berries = context.Berries.Where(b => b.MaxHarvest > 1);
                Console.WriteLine(berries.FirstOrDefault().FirmnessId);
            }

        }
    }
}
