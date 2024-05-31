using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Polearm : Weapon
    {
        public Polearm() : base("Polearm", 18) { }
        public Polearm(int damage) : this()
        {
            AttackBonus = damage;
        }
    }
}
