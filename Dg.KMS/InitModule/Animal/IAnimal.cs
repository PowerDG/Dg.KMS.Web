using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animal
{
    //https://www.cnblogs.com/Chary/p/11351457.html
    //深入浅出依赖注入容器——Autofac

    public interface IAnimal
    {
        void SayHello();
    }
    public class Doge : IAnimal
    {
        public void SayHello()
        {
            Console.WriteLine("我是小狗，汪汪汪~");
        }
    }
    public class Cat : IAnimal
    {
        public void SayHello()
        {
            Console.WriteLine("我是小猫，喵喵喵~");
        }
    }
    public class Pig : IAnimal
    {
        public void SayHello()
        {
            Console.WriteLine("我是小猪，呼呼呼~");
        }
    }

}
