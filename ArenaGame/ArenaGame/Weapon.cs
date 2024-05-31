using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Weapon
    {
        public string Name { get; set; }
        public int AttackBonus { get; set; }

        public Weapon(string name, int attackBonus)
        {
            Name = name;
            AttackBonus = attackBonus;
        }
    }
}
