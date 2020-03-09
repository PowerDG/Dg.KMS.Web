using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Dg.Extensions
{
    public static class LambdaExtension
    {

        #region if

        /// <summary>
        /// 
        /// 对引用类型我们可以使用Action<T>，也以使用链式编程的方式将多个If串起来。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="predicate"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static T If<T>(this T t, Predicate<T> predicate, Action<T> action) where T : class
        {
            if (t == null) throw new ArgumentNullException();
            if (predicate(t)) action(t);
            return t;
        }
        public static T If<T>(this T t, Predicate<T> predicate, params Action<T>[] actions) where T : class
        {
            if (t == null) throw new ArgumentNullException();
            if (predicate(t))
            {
                foreach (var action in actions)
                    action(t);
            }
            return t;
        }

        /// <summary>
        /// 但对值类型来说，就要用Func<T, T> 了，每次返回一个新的值 ： 

        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="predicate"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static T If<T>(this T t, Predicate<T> predicate, Func<T, T> func) where T : struct
        {
            return predicate(t) ? func(t) : t;
        }
        /// <summary>
        /// 两个扩展，一个是给值类型的，一个给引用类型，可string类型在这里都不行
        /// </summary>
        /// <param name="s"></param>
        /// <param name="predicate"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static string If(this string s, Predicate<string> predicate, Func<string, string> func)
        {
            return predicate(s) ? func(s) : s;
        }
        #endregion

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

        #region While
        public static void While<T>(this T t, Predicate<T> predicate, Action<T> action) where T : class
        {
            while (predicate(t)) action(t);
        }
        public static void While<T>(this T t, Predicate<T> predicate, params Action<T>[] actions) where T : class
        {
            while (predicate(t))
            {
                foreach (var action in actions)
                    action(t);
            }
        }
        #endregion


        #region Switch
        public static TOutput Switch<TOutput, TInput>(this TInput input, IEnumerable<TInput> inputSource, IEnumerable<TOutput> outputSource, TOutput defaultOutput)
        {
            IEnumerator<TInput> inputIterator = inputSource.GetEnumerator();
            IEnumerator<TOutput> outputIterator = outputSource.GetEnumerator();

            TOutput result = defaultOutput;
            while (inputIterator.MoveNext())
            {
                if (outputIterator.MoveNext())
                {
                    if (input.Equals(inputIterator.Current))
                    {
                        result = outputIterator.Current;
                        break;
                    }
                }
                else break;
            }
            return result;
        }




        #endregion

    }

    public static class SwithCaseExtension
    {
        public class SwithCase<TCase, TOther>
        {
            public SwithCase(TCase value, Action<TOther> action)
            {
                Value = value;
                Action = action;
            }
            public TCase Value { get; private set; }
            public Action<TOther> Action { get; private set; }
        }





        //}

        #region Swith
        public static SwithCase<TCase, TOther> Switch<TCase, TOther>(this TCase t, Action<TOther> action) where TCase : IEquatable<TCase>
        {
            return new SwithCase<TCase, TOther>(t, action);
        }

        public static SwithCase<TCase, TOther> Switch<TInput, TCase, TOther>(this TInput t, Func<TInput, TCase> selector, Action<TOther> action) where TCase : IEquatable<TCase>
        {
            return new SwithCase<TCase, TOther>(selector(t), action);
        }
        #endregion

        #region Case
        public static SwithCase<TCase, TOther> Case<TCase, TOther>(this SwithCase<TCase, TOther> sc, TCase option, TOther other) where TCase : IEquatable<TCase>
        {
            return Case(sc, option, other, true);
        }


        public static SwithCase<TCase, TOther> Case<TCase, TOther>(this SwithCase<TCase, TOther> sc, TCase option, TOther other, bool bBreak) where TCase : IEquatable<TCase>
        {
            return Case(sc, c => c.Equals(option), other, bBreak);
        }


        public static SwithCase<TCase, TOther> Case<TCase, TOther>(this SwithCase<TCase, TOther> sc, Predicate<TCase> predict, TOther other) where TCase : IEquatable<TCase>
        {
            return Case(sc, predict, other, true);
        }

        public static SwithCase<TCase, TOther> Case<TCase, TOther>(this SwithCase<TCase, TOther> sc, Predicate<TCase> predict, TOther other, bool bBreak) where TCase : IEquatable<TCase>
        {
            if (sc == null) return null;
            if (predict(sc.Value))
            {
                sc.Action(other);
                return bBreak ? null : sc;
            }
            else return sc;
        }
        #endregion

        #region Default
        public static void Default<TCase, TOther>(this SwithCase<TCase, TOther> sc, TOther other)
        {
            if (sc == null) return;
            sc.Action(other);

        }
        #endregion
    }
}