using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp
{
    /// <summary>
    /// Liskov Substitution Principle (LSP)
    /// </summary>
    public class FirePokemon : Pokemon
    {
        public string FireTypeMove { get; set; }
    }
}
