using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animal.GameStrategy
{
    /// <summary>
    /// 怪物
    /// </summary>
    public class Monster
    {        
        /// <summary>
        /// 怪物的生命值
        /// </summary>
        public Int32 HP { get; set; }

        public Monster(String name, Int32 hp)
        {
            this.Name = name;
            this.HP = hp;
        }
        /// <summary>
        /// 怪物的名字
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// 怪物被攻击时，被调用的方法，用来处理被攻击后的状态更改
        /// </summary>
        /// <param name="loss">此次攻击损失的HP</param>
        public void Notify(Int32 loss)
        {
            if (this.HP <= 0)
            {
                Console.WriteLine("此怪物已死");
                return;
            }

            this.HP -= loss;
            if (this.HP <= 0)
            {
                Console.WriteLine("怪物" + this.Name + "被打死");
            }
            else
            {
                Console.WriteLine("怪物" + this.Name + "损失" + loss + "HP");
            }
        }


    }
}
