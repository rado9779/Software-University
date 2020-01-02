using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();

            while (true)
            {
                string[] line = Console.ReadLine()
                     .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (line[0] == "Tournament")
                {
                    break;
                }

                string trainerName = line[0];
                string pokemonName = line[1];
                string pokemonElement = line[2];
                double pokemonHealth = double.Parse(line[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if (trainers.Any(x => x.Name == trainerName))
                {
                    int trainerIndex = trainers.FindIndex(x => x.Name == trainerName);
                    trainers[trainerIndex].CollectionOfPokemon.Add(pokemon);
                }
                else
                {
                    Trainer trainer = new Trainer(trainerName, pokemon);
                    trainers.Add(trainer);
                }

            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                foreach (var trainer in trainers)
                {
                    if (trainer.CollectionOfPokemon.Any(x => x.Element == command))
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        trainer.CollectionOfPokemon.ForEach(x => x.Health -= 10);
                        trainer.CollectionOfPokemon.RemoveAll(x => x.Health <= 0);
                    }
                }
            }

            trainers = trainers
                .OrderByDescending(x => x.Badges)
                .ToList();

            foreach (Trainer trainer in trainers)
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.CollectionOfPokemon.Count()}");
            }
        }
    }
}
