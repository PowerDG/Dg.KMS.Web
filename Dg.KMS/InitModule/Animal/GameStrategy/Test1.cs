using Animal.DependencyLocate;
using Animal.DgContext;
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
        public void Test13()
        {
            IServiceClass serviceA = new ServiceClassA();
            IServiceClass serviceB = new ServiceClassB();
            ClientClass client = new ClientClass();

            client.Set_ServiceImpl(serviceA);
            client.ShowInfo();
            client.Set_ServiceImpl(serviceB);
            client.ShowInfo();
        }

        /// <summary>
        /// https://www.cnblogs.com/leoo2sk/archive/2009/06/17/di-and-ioc.html#
        /// </summary>
        public void FactoryContainerTest()
        {
            IFactory factory = FactoryContainer.factory;
            IWindow window = factory.MakeWindow();
            Console.WriteLine("创建 " + window.ShowInfo());
            IButton button = factory.MakeButton();
            Console.WriteLine("创建 " + button.ShowInfo());
            ITextBox textBox = factory.MakeTextBox();
            Console.WriteLine("创建 " + textBox.ShowInfo());

            Console.ReadLine();
        }
        public void MakeWindowTest()
        {
            IFactory factory = FactoryContainer.factory;
            IWindow window = factory.MakeWindow();
            Console.WriteLine("创建 " + window.ShowInfo());
            IButton button = factory.MakeButton();
            Console.WriteLine("创建 " + button.ShowInfo());
            ITextBox textBox = factory.MakeTextBox();
            Console.WriteLine("创建 " + textBox.ShowInfo());

            Console.ReadLine();
        }
    }
}
