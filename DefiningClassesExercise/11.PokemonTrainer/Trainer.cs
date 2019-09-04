using System.Collections.Generic;

namespace _11.PokemonTrainer
{
    public class Trainer
    {
        public Trainer(string name, int badges, List<Pokemon> pokemon)
        {
            this.Name = name;
            this.Badges = badges;
            this.Pokemon = pokemon;
        }

        public string Name { get; set; }

        public int Badges { get; set; }

        public List<Pokemon> Pokemon { get; set; }
    }
}
