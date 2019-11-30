using Animal.GameStrategy.GameLiAdv;
using Animal.GameStrategy.NPC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animal.GameStrategy
{
    public class Test
    {

        public void Test1()
        {
            Monster monster1 = new Monster("小怪A", 50);
            Monster monster2 = new Monster("小怪B", 50);
            Monster monster3 = new Monster("关主", 200);
            Monster monster4 = new Monster("最终Boss", 1000);

            //生成角色
            Role role = new Role();

            //木剑攻击
            role.Weapon = new WoodSword();
            role.Attack(monster1);

            //铁剑攻击
            role.Weapon = new IronSword();
            role.Attack(monster2);
            role.Attack(monster3);

            //魔剑攻击
            role.Weapon = new MagicSword();
            role.Attack(monster3);
            role.Attack(monster4);
            role.Attack(monster4);
            role.Attack(monster4);
            role.Attack(monster4);
            role.Attack(monster4);

            //Console.ReadLine();
        }
    }
}
