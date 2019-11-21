using System;
using System.Collections.Generic;
using System.Linq;

namespace NotNullTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = GetDict();
            Console.WriteLine("Hello World!" + dict[221] + "--" + ProductsMapper().ToList().Count() + "！！");
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

            var c=recountDict[0];

        
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
            if (!Items.Select(x=>x.POId).Contains(item.POId))
            {
                Items.Add(item);
                TotalNum += item.Num; 
                Cost += item.Cost; 
                BaseCost += item.BaseCost;
            }
            return Items.Count;
        }
        public  bool CheckFigureOut()
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
