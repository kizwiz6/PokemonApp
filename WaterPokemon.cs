using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp
{
    public class WaterPokemon : Pokemon, ICanSwim
    {
        public void Swim()
        {
            throw new NotImplementedException();
        }
    }
}
