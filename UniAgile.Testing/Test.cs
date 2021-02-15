using System;

namespace UniAgile.Testing
{
    public static class Test
    {
        /// <summary>
        ///     Starts a new test sequence
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public static Case If(Action action)
        {
            action();

            return new Case();
        }


        /// <summary>
        ///     Assertion for multiples
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="action"></param>
        /// <typeparam name="T"></typeparam>
        public static void Are<T>(this T[]  collection,
                                  Action<T> action)
        {
            foreach (var elem in collection) elem.Is(action);
        }

        /// <summary>
        ///     Assertion for single
        /// </summary>
        /// <param name="elem"></param>
        /// <param name="action"></param>
        /// <typeparam name="T"></typeparam>
        public static void Is<T>(this T    elem,
                                 Action<T> action)
        {
            action(elem);
        }
    }
}