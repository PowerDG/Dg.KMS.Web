using Newtonsoft.Json;
using Paged;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NotNullTest
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("aaa");
            DateTime? ad = null;
             var cc=(ad)?.ToString("yyyy-MM-dd HH:mm:ss");

            Console.WriteLine("bbb");
            Console.WriteLine(cc);

            Console.WriteLine("ccc");
            //NullModelTest();

            ////PageTest();
            //extendLoadGamePrint();
            //var dict = GetDict();
            //Console.WriteLine("Hello World!" + dict[221] + "--" + ProductsMapper().ToList().Count() + "！！");
        }

        public static void extendLoadGamePrint()
        {
            new TestProgram().loadGame();
        }
        public static void CurrentPagerTest()
        {
            var pager = new Paged.PagerTest();
        }
        public static void PageTest()
        {
            var list = GetPageTest();
            //List<int>
            var c = list.OrderByDescending(x=>x);
            var pageSize = 99;
            var length = list.Count();
            var pageNo = length / pageSize;
            var currentList = new List<int>();
            for (int i = 1; i <= pageNo + 1; i++)
            {
                currentList = list.Skip((i - 1) * pageSize).Take(pageSize).ToList();
                //var currentDict = await orderListManager.GetBasePriceDictAsync(currentList, orderNo, requestTracked);
                Console.WriteLine($"{i }---{JsonConvert.SerializeObject(currentList)}");
            }
        }

        public static void NullModelTest()
        {

            Model2 mm = new Model2();
            mm = null;
            var list = new List<Model2>();
            list = null;
            if (!(list?.Any()?? false))
            {
                Console.WriteLine($" null--");
            }
            else
            {

                Console.WriteLine($"not null");
            }



        }

        public static void NullStrTest()
        {

            Model2 mm = new Model2();
            mm.Remark = null;
            var c = TestNullStr(mm);
            Console.WriteLine($"{c}---{JsonConvert.SerializeObject(c)}");



        }
        public static string TestNullStr(Model2 mo)
        {

            var remark = @"UpdateBaseCost|";
            if (!string.IsNullOrWhiteSpace(mo.Remark))
            {
                var entityReamrk = mo.Remark ?? "";
                if (!entityReamrk.StartsWith("UpdateBaseCost|"))
                {
                    remark += entityReamrk;
                }
            }
            return remark;
        }

        public static List<int> GetPageTest()
        {
            var list = new List<int>();
            for (int i = 0; i < 698; i++)
            {
                list.Add(i);
            }
            return list;
        }

        public static IEnumerable<int> ProductsMapper()
        {
            List<int> list = new List<int>();
            var briefProducts = list.Where(x => x.ToString().Length < 3).Select(x => x).Distinct();
            //var briefProducts = AutoMapper.Mapper.Map<List<PurchaseBriefProductItem>>(products);
            return briefProducts;
        }
        public static Dictionary<int, string> GetDict()
        {
            return new Dictionary<int, string>()
            {
                { 1,"123"},
                { 3,"123"}
            };
        }

        public static List<CheckList> GetItemList()
        {
            return new List<CheckList>()
            {
                new CheckList(1,5),
                new CheckList(1,6),
                new CheckList(2,5),
                new CheckList(2,7),
                new CheckList(3,5),
            };
        }
        public void d()
        {
            Dictionary<int, CheckList> recountDict = new Dictionary<int, CheckList>();

            var c = recountDict[0];


        }
    }

    public class CheckList
    {
        public CheckList(int id, int PKID)
        {
            this.ItemId = id;
            this.PKID = PKID;
        }
        public virtual int PKID { get; set; }
        public virtual int ItemId { get; set; }
        public HashSet<CheckItem> Items { get; set; }

        public virtual int TotalNum { get; set; }

        public virtual decimal Cost { get; set; }
        public virtual decimal BaseCost { get; set; }
        public int Add(CheckItem item)
        {
            if (!Items.Select(x => x.POId).Contains(item.POId))
            {
                Items.Add(item);
                TotalNum += item.Num;
                Cost += item.Cost;
                BaseCost += item.BaseCost;
            }
            return Items.Count;
        }
        public bool CheckFigureOut()
        {
            if (true)
            {

            }
            return false;
        }
    }
    public class CheckItem
    {
        public CheckItem(int id, int POId)
        {
            this.POId = id;
            this.POId = POId;
        }
        public virtual int OrderListId { get; set; }
        public virtual string Pid { get; set; }
        public virtual int Num { get; set; }
        public virtual int POId { get; set; }
        public virtual decimal Cost { get; set; }
        public virtual decimal BaseCost { get; set; }
    }
}
