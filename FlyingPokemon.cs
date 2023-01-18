using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp
{
    public class FlyingPokemon : Pokemon, ICanFly
    {
        public void Fly()
        {
            throw new NotImplementedException();
        }
    }
}
