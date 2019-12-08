using System;
using System.Collections.Generic;
using System.Text;

namespace Paged
{
    public class MyPager
    {  /// <summary>
       /// 内存对象翻页
       /// </summary>
       /// <typeparam name="table">实体类型</typeparam>
       /// <param name="pageIndex">当前页数</param>
       /// <param name="rowCount">每页的条数</param>
       /// <param name="listModel">实体集合</param>
       /// <param name="filterModel">筛选实体参数</param>
       /// <param name="pk">主键</param>
       /// <param name="order">排序字段</param>
       /// <returns>翻页数据</returns>
        public static object Pager<Ttable>(int pageIndex, int pageSize, List<Ttable> source, Ttable filterModel, String pk = "ID", String order = "ID")
            where Ttable : EntityObject
        {
            try
            {
                Func<Ttable, Boolean> filterItem = null;                // 筛选回调函数指针
                Func<Ttable, int> orderItem = null;                     // 排序回调函数指针

                #region 处理筛选条件

                if (filterModel != null)
                {
                    foreach (var item in filterModel.GetType().GetProperties())  // 遍历筛选条件
                    {
                        object pro = item.GetValue(filterModel, null);
                        string proName = item.Name;
                        if (pro != null)
                        {
                            if (pro.GetType() == typeof(int) && !proName.Equals(pk)) // 当过滤参数类型为int类型的时候，屏蔽主键
                            {
                                filterItem += new Func<Ttable, Boolean>(
                                delegate (Ttable model)
                                {
                                    object modelPro = item.GetValue(model, null);
                                    if (modelPro == pro)
                                    {
                                        return true;
                                    }
                                    return false;
                                });
                            }
                            if (pro.GetType() == typeof(string) && !pro.ToString().Equals(""))   // 当过滤参数为String类型的时候，屏蔽空字符串
                            {
                                filterItem += new Func<Ttable, Boolean>(
                                delegate (Ttable model)
                                {
                                    String modelPro = item.GetValue(model, null).ToString();
                                    if (modelPro.IndexOf(pro.ToString()) >= 0)
                                    {
                                        return true;
                                    }
                                    return false;
                                });
                            }
                            // ...
                        }
                        if (proName.Equals(order))                                      // 排序判断回调
                        {
                            if (pro.GetType() == typeof(int))                           // 只对Int类型数据进行排序判断
                            {
                                orderItem += new Func<Ttable, int>(
                                delegate (Ttable model)
                                {
                                    int modelPro = (int)item.GetValue(model, null);
                                    return modelPro;
                                });
                            }
                        }
                    }
                }

                var vList = source.Where(m =>
                {
                    Boolean mrt = false;
                    if (filterItem != null)
                    {
                        if (filterItem(m))                     // 筛选数据判断，每一条数据都会判断一下，所以回调函数存在效率问题
                        {
                            mrt = true;
                        }
                    }
                    else
                    {
                        mrt = true;
                    }
                    return mrt;
                });         // 筛选后数据集

                #endregion

                #region 求总数

                Int32 totalCount = vList.Count();                       // 当前筛选条件的总条数
                if (totalCount <= (pageIndex - 1) * pageSize)           // 当前页数没有记录
                {
                    return new Models.PageModel() { TotalCount = 0, Data = new List<object>() };
                }

                #endregion

                #region 处理排序

                if (orderItem != null)
                {
                    vList = vList.OrderBy(orderItem, new CompareIntegers());
                }

                #endregion

                #region 处理翻页

                vList = vList.Skip((pageIndex - 1) * pageSize).Take(pageSize);
                Models.PageModel pm = new Models.PageModel() { TotalCount = totalCount, Data = vList.ToList() };

                return pm;

                #endregion

            }
            catch { }
            return null;
        }
        // DESC
        public class CompareIntegers : IComparer<int>
        {
            public int Compare(int i1, int i2)
            {
                return i2 - i1;
            }
        }

    }
}
