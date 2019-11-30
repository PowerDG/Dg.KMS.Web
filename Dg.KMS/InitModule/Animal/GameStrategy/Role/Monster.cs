using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animal.GameStrategy
{
    /// <summary>
    /// 怪物
    /// </summary>
    internal sealed class Monster
    {
        /// <summary>
        /// 怪物的名字
        /// </summary>
        public String Name { get; set; }

        internal void Notify(int v)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 怪物的生命值
        /// </summary>
        public Int32 HP { get; set; }

        public Monster(String name, Int32 hp)
        {
            this.Name = name;
            this.HP = hp;
        }
    }
}
