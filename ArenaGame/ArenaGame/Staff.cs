using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Staff : Weapon
    {
        public Staff() : base("Wand", 12) { }
        public Staff(int damage) : this()
        {
            AttackBonus = damage;
        }
    }
}
