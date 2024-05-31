using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Hunter : Hero
    {
        private int agility;

        public Hunter(string name) : base(name)
        {
            Weapon = new Polearm();
            agility = 5;
        }

        public override void TakeDamage(int incomingDamage)
        {
            if (ThrowDice(50)) incomingDamage = 0;
            base.TakeDamage(incomingDamage);
        }

        public override int Attack()
        {
            int attack = base.Attack();
            if (ThrowDice(20)) attack = attack + (agility * 3);
            return attack;
        }
    }
}
