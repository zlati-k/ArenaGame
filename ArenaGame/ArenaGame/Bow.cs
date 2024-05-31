using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Bow : Weapon
    {
        public Bow() : base("Bow", 15) { }
        public Bow(int damage) : this()
        {
            AttackBonus = damage;
        }
    }
}
