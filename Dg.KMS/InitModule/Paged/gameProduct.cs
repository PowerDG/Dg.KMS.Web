using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Paged
{
    public class gameProduct
    {//游戏商品类object
        private Int32 gameId;       //所属游戏ID
        private Int32 productType;  //商品类型ID
        private Decimal price;      //商品单价

        #region 字段
        public Int32 GameId
        {
            get { return gameId; }
            set { gameId = value; }
        }
        public Int32 ProductType
        {
            get { return productType; }
            set { productType = value; }
        }
        public Decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        #endregion

        static gameProduct() { }
        public gameProduct() { }
        public gameProduct(Int32 gameId, Int32 productType, Decimal price) : this()
        {
            this.gameId = gameId;
            this.productType = productType;
            this.price = price;
        }

        public override string ToString()
        {//重写object的ToString方法
            return "[游戏ID:" + this.gameId + ",商品类型ID:" + this.productType + ",商品单价:" + price + "]";
        }
    }

    public class TestProgram
    {//程序入口
        public void loadGame()
        {
            //
            List<gameProduct> list = new List<gameProduct>();
            list.Add(new gameProduct(1, 101, 100));
            list.Add(new gameProduct(1, 102, 2));
            list.Add(new gameProduct(1, 101, 50));
            list.Add(new gameProduct(2, 106, 13));
            list.Add(new gameProduct(2, 103, 18));
            list.Add(new gameProduct(5, 118, 9));
            //请先看下面extendClass解释
            var enum_1 = list.Select(g => g);//等价于list.Select<gameProduct, gameProduct>(g => g);--<参数类型，返回值类型>;
            //很多人就疑惑了，Select方法是哪里来的？！！它是.net framework 3.5以后加上的扩展方法在System.Linq下的Enumerable类中.见下面extendClass解释。
            //很多人就又疑惑了，g => g这是个什么写法没见过啊!。它是lambda表达式，其实是个(委托+匿名函数)的简化写法，稍后解释
            Console.WriteLine(enum_1.MyPrint());//看它返回的是什么，先来体验一下
            //var enum_2 = list.Select(delegate(gameProduct g){return g;});//这个就是g => g  ---lambda表达式的原型.就是传一个函数指针，指针指向这个匿名的方法
            //有的人就疑惑了，lambda表达式怎么没有参数类型？它是推断类型，根据上下文Context推断出来的。
            var enum_3 = list.Select(g => g).Where(g => g.GameId == 1);//选择所有的数据没意思，我们来点条件
            Console.WriteLine("筛选后：" + enum_3.MyPrint());

            var enum_4 = list.OrderBy(g => g.Price);//根据单价排序
            Console.WriteLine("排序后：" + enum_4.MyPrint());

            IEnumerable<IGrouping<Int32, gameProduct>> groups_1 = list.GroupBy(g => g.GameId);//分组查询
            Console.WriteLine("分组后：" + groups_1.MyPrint());

            Console.ReadKey();

        }
    }

    public static class extendClass
    {//存放所有扩展方法
     //有些人就会问了，什么是扩展方法？扩展方法有什么用？
     //文字解释:很多情况下，我们想对一些final类添加一个方法，而这个final类是不能被继承的，只能通过扩展方法来解决.
     //比如，我要给List<gameProduct>这个泛型集合添加一个MyPrint方法。我们可以这样做，注意函数签名.
        public static String MyPrint(this IEnumerable<object> list)
        {//注意函数签名，这里文字叙述太麻烦。这个时候我们会发现所有的IEnumerable<object>都有这个方法
            String rt = "";
            IEnumerator<object> eartor = list.GetEnumerator();//获得枚举器
            rt += "{\n";
            while (eartor.MoveNext())
            {
                rt += eartor.Current.ToString() + ",\n";
            }
            rt += "}";
            return rt;
        }

    }
}
