using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();

            while (true)
            {
                var line = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (line[0] == "Tournament")
                {
                    break;
                }
                string trainerName = line[0];
                string pokemonName = line[1];
                string element = line[2];
                int health = int.Parse(line[3]);

                Pokemon pokemon = new Pokemon(pokemonName, element, health);
                Trainer trainer = new Trainer(trainerName, 0, new List<Pokemon>());
                trainer.Pokemon.Add(pokemon);

                bool wasAdded = false;
                foreach (var trainerr in trainers)
                {
                    if (trainerr.Name == trainerName)
                    {
                        trainerr.Pokemon.Add(pokemon);
                        wasAdded = true;
                        break;
                    }
                }
                if (!wasAdded)
                {
                    trainers.Add(trainer);
                }
            }
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }
                foreach (var trainer in trainers)
                {
                    if (trainer.Pokemon.Any(x => x.Element == line) && trainer.Pokemon.Count >= 1)
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        for (int i = 0; i < trainer.Pokemon.Count; i++)
                        {
                            if (trainer.Pokemon[i].Health-10 > 0)
                            {
                                trainer.Pokemon[i].Health -= 10;
                            }
                            else
                            {
                                trainer.Pokemon.RemoveAt(i);
                                i--;
                            }
                        }
                    }
                }
            }
            foreach (var trainer in trainers.OrderByDescending(x=>x.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemon.Count}");
            }
        }
    }
}
