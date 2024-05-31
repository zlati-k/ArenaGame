using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Sword : Weapon
    {
        public Sword() : base("Sword", 20) { }
        public Sword(int damage) : this() {
            AttackBonus = damage;
        }

    }
}
