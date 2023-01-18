using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp
{
    public class PokemonTrainer
    {
        private readonly IPokemon _pokemon;

        public PokemonTrainer(IPokemon pokemon)
        {
            _pokemon = pokemon;
        }

        public void TrainPokemon()
        {

        }
    }
}
