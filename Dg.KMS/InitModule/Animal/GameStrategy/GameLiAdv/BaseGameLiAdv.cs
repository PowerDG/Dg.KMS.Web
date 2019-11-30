using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animal.GameStrategy.GameLiAdv
{
    public class BaseGameLiAdv
    {
    }
    public class WoodSword : IAttackStrategy
    {
        public void AttackTarget(Monster monster)
        {
            monster.Notify(20);
        }
    }
    public class IronSword : IAttackStrategy
    {
        public void AttackTarget(Monster monster)
        {
            monster.Notify(50);
        }
    }

    public class MagicSword : IAttackStrategy
    {
        private Random _random = new Random();

        public void AttackTarget(Monster monster)
        {
            Int32 loss = (_random.NextDouble() < 0.5) ? 100 : 200;
            if (200 == loss)
            {
                Console.WriteLine("出现暴击！！！");
            }
            monster.Notify(loss);
        }
    }
}
