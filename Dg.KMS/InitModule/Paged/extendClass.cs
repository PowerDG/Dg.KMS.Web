using System;
using System.Collections.Generic;
using System.Text;

namespace Paged
{
    public static class extendClass
    {
        // 比如，我要给List<gameProduct>这个泛型集合添加一个MyPrint方法。我们可以这样做，注意函数签名.
        public static String MyPrint(this IEnumerable<object> list)
        {
            String rt = "";
            IEnumerator<object> eartor = list.GetEnumerator();// 获得枚举器
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
