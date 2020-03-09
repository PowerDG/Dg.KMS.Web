using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Dg.Extensions
{
    public static class LambdaExtension
    {
        #region WhereIfExtension

        /// <summary>
        ///https://www.cnblogs.com/ldp615/archive/2011/02/17/WhereIf-ExtensionMethod.html
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="predicate"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static IQueryable<T> WhereIf<T>(this IQueryable<T> source, Expression<Func<T, bool>> predicate, bool condition)
        {
            return condition ? source.Where(predicate) : source;
        }
        public static IQueryable<T> WhereIf<T>(this IQueryable<T> source, Expression<Func<T, int, bool>> predicate, bool condition)
        {
            return condition ? source.Where(predicate) : source;
        }
        public static IEnumerable<T> WhereIf<T>(this IEnumerable<T> source, Func<T, bool> predicate, bool condition)
        {
            return condition ? source.Where(predicate) : source;
        }
        public static IEnumerable<T> WhereIf<T>(this IEnumerable<T> source, Func<T, int, bool> predicate, bool condition)
        {
            return condition ? source.Where(predicate) : source;
        }

        #endregion

        #region IsBetween
        /// <summary>
        /// https://www.cnblogs.com/ldp615/archive/2011/02/18/IsBetween-ExtensionMethod.html
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="lowerBound"></param>
        /// <param name="upperBound"></param>
        /// <param name="includeLowerBound"></param>
        /// <param name="includeUpperBound"></param>
        /// <returns></returns>
        public static bool IsBetween<T>(this T t, T lowerBound, T upperBound,
            bool includeLowerBound = false, bool includeUpperBound = false)
        where T : IComparable<T>
        {
            if (t == null) throw new ArgumentNullException("t");

            var lowerCompareResult = t.CompareTo(lowerBound);
            var upperCompareResult = t.CompareTo(upperBound);

            return (includeLowerBound && lowerCompareResult == 0) ||
                (includeUpperBound && upperCompareResult == 0) ||
                (lowerCompareResult > 0 && upperCompareResult < 0);
        }
        public static bool IntIsBetween(this int i, int lowerBound, int upperBound,
            bool includeLowerBound = false, bool includeUpperBound = false)
        {
            return (includeLowerBound && i == lowerBound) ||
                (includeUpperBound && i == upperBound) ||
                (i > lowerBound && i < upperBound);
        }
        public static bool IntIsBetween(this long i, long lowerBound, long upperBound,
            bool includeLowerBound = false, bool includeUpperBound = false)
        {
            return (includeLowerBound && i == lowerBound) ||
                (includeUpperBound && i == upperBound) ||
                (i > lowerBound && i < upperBound);
        }
        public static bool DoubleIsBetween(this float i, float lowerBound, float upperBound,
                bool includeLowerBound = false, bool includeUpperBound = false)
        {
            return (includeLowerBound && i == lowerBound) ||
                (includeUpperBound && i == upperBound) ||
                (i > lowerBound && i < upperBound);
        }

        #endregion
    }
}
