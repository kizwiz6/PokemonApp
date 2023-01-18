using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp
{
    public interface IPokemon
    {
        string Name { get; set; }
        int HP { get; set; }
        int Attack { get; set; }
        int Defense { get; set; }
        int SpecialAttack { get; set; }
        int SpecialDefense { get; set; }
        int Speed { get; set; }
        List<PokemonMove> Moves { get; set; }

        void TakeDamage(int damage);
        void UseMove(PokemonMove move, Pokemon target);
    }
}
