﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animal.GameStrategy.GameLiAdv
{
    public class BaseGameLiAdv
    {
    }
    internal sealed class WoodSword : IAttackStrategy
    {
        public void AttackTarget(Monster monster)
        {
            monster.Notify(20);
        }
    }
    internal sealed class IronSword : IAttackStrategy
    {
        public void AttackTarget(Monster monster)
        {
            monster.Notify(50);
        }
    }

    internal sealed class MagicSword : IAttackStrategy
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
