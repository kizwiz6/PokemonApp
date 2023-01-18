using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp
{
    public class Pokemon : IPokemon
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpecialAttack { get; set; }
        public int SpecialDefense { get; set; }
        public int Speed { get; set; }
        public List<PokemonMove> Moves { get; set; }

        public void TakeDamage(int damage)
        {
            HP -= damage;
        }

        public void UseMove(PokemonMove move, Pokemon target)
        {
            // logic for using a move on a target
        }
    }
}
