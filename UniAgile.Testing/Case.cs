using System;

namespace UniAgile.Testing
{
    public struct Case
    {
        /// <summary>
        ///     Starts a new sequence for target parameter
        /// </summary>
        /// <param name="parameter"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T And<T>(T parameter)
        {
            return parameter;
        }


        /// <summary>
        ///     Asserts pre-requisite for multiples
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public Case Are(Action action)
        {
            action();

            return this;
        }


        /// <summary>
        ///     Asserts pre-requisite
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public Case Is(Action action)
        {
            action();

            return this;
        }

        /// <summary>
        ///     Asserts pre-requisite
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public Case If(Action action)
        {
            return this;
        }


        /// <summary>
        ///     Behaviour which changes state
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public Case When(Action action)
        {
            action();

            return this;
        }


        /// <summary>
        ///     Behaviour which changes state
        /// </summary>
        /// <param name="action"></param>
        /// <param name="param"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public Case When<T>(Action<T> action,
                            T         param)
        {
            action(param);

            return this;
        }


        /// <summary>
        ///     Behaviour which changes state
        /// </summary>
        /// <param name="action"></param>
        /// <param name="param1"></param>
        /// <param name="param2"></param>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <returns></returns>
        public Case When<T1, T2>(Action<T1, T2> action,
                                 T1             param1,
                                 T2             param2)
        {
            action(param1, param2);

            return this;
        }

        /// <summary>
        ///     Behaviour which changes state
        /// </summary>
        /// <param name="action"></param>
        /// <param name="param1"></param>
        /// <param name="param2"></param>
        /// <param name="param3"></param>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <returns></returns>
        public Case When<T1, T2, T3>(Action<T1, T2, T3> action,
                                     T1                 param1,
                                     T2                 param2,
                                     T3                 param3)
        {
            action(param1, param2, param3);

            return this;
        }

        /// <summary>
        ///     Asserts the end result of the test sequence
        /// </summary>
        /// <param name="action"></param>
        public void Then(Action action)
        {
            action();
        }

        /// <summary>
        ///     Asserts the end result of the test sequence
        /// </summary>
        /// <param name="action"></param>
        /// <param name="param"></param>
        /// <typeparam name="T"></typeparam>
        public void Then<T>(Action<T> action,
                            T         param)
        {
            action(param);
        }


        /// <summary>
        ///     Asserts the end result of the test sequence
        /// </summary>
        /// <param name="action"></param>
        /// <param name="param1"></param>
        /// <param name="param2"></param>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        public void Then<T1, T2>(Action<T1, T2> action,
                                 T1             param1,
                                 T2             param2)
        {
            action(param1, param2);
        }

        /// <summary>
        ///     Asserts the end result of the test sequence
        /// </summary>
        /// <param name="action"></param>
        /// <param name="param1"></param>
        /// <param name="param2"></param>
        /// <param name="param3"></param>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        public void Then<T1, T2, T3>(Action<T1, T2, T3> action,
                                     T1                 param1,
                                     T2                 param2,
                                     T3                 param3)
        {
            action(param1, param2, param3);
        }
    }
}