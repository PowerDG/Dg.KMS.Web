using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animal.GameStrategy
{
    public interface IAttackStrategy
    {
        void AttackTarget(Monster monster);
    }
}
