using System;
using System.Collections.Generic;
using System.Text;

namespace Paged
{
    public class PagerTest
    {
        public void test()
        {

            List<gameProduct> list = new List<gameProduct>();
            list.Add(new gameProduct(1, 101, 100));
            list.Add(new gameProduct(1, 102, 2));
            list.Add(new gameProduct(1, 101, 50));
            list.Add(new gameProduct(2, 106, 13));
            list.Add(new gameProduct(2, 103, 18));
            list.Add(new gameProduct(5, 118, 9));

            var enum_1 = list.Select(g => g);
            // var enum_2 = list.Select(delegate(gameProduct g){return g;});// 这个就是g => g 
            Console.WriteLine(enum_1.MyPrint());   // 看它返回的是什么，先来体验一下

        }
    }

    public class gameProduct
    {
        public gameProduct(int lenght,int fighting, int age)
        {
            this.lenght = lenght;

            this.fighting = fighting;

            this.age = age;

        }
        public int lenght { get; set; }

        public int age { get; set; }

        public int fighting { get; set; }
    }
}
