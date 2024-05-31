using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Archer : Hero
    {
        private int accuracy;

        public Archer(string name) : base(name)
        {
            Weapon = new Bow();
            accuracy = 5;
        }

        public override void TakeDamage(int incomingDamage)
        {
            if (ThrowDice(20)) incomingDamage /= 2;
            base.TakeDamage(incomingDamage);
        }

        public override int Attack()
        {
            int attack = base.Attack();
            if (ThrowDice(30)) attack = attack * accuracy / 2;
            return attack;
        }
    }
}
