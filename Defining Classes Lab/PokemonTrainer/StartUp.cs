using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var trainers = new List<Trainer>();
            string inputLine;
            while ((inputLine=Console.ReadLine())!= "Tournament")
            {
                var input = inputLine.Split(new[] {' '}).Select(x=>x.Trim()).ToArray();
                var trName = input[0];
                var pkName = input[1];
                var pkElement = input[2];
                var pkHealt = int.Parse(input[3]);
                var pokemon=new Pokemon(pkName,pkElement,pkHealt);
                var trainer=new Trainer(trName,pokemon);
                if (trainers.Where(t => t.Name == trName).FirstOrDefault()==null)
                {
                    trainers.Add(trainer);
                    continue;
                }
                trainers.Where(t => t.Name == trName).FirstOrDefault().AddPokemon(pokemon);
            }

            while ((inputLine=Console.ReadLine())!="End")
            {
                var command = inputLine.Trim();
                foreach (Trainer t in trainers)
                {
                    if (t.Pokemons.Where(p => p.Element == command).FirstOrDefault()==null)
                    {
                        t.PokemonDmg();
                        continue;
                    }
                    t.Badges++;
                }
            }
            foreach (var trainer in trainers.OrderByDescending(tr=>tr.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
        }
    }
}
