using System.Collections.Generic;

namespace PokemonTrainer
{
    public class Trainer
    {
        public Trainer(string name,Pokemon pokemon)
        {
            this.Name = name;
            this.CollectionOfPokemon = new List<Pokemon>();
            this.CollectionOfPokemon.Add(pokemon);
        }

        public string Name { get; set; }

        public int Badges { get; set; }

        public List<Pokemon> CollectionOfPokemon { get; set; } 
    }
}
