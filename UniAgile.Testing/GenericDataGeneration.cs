﻿using System.Collections;
using System.Collections.Generic;
using Moq;

namespace UniAgile.Testing
{
    public static class GenericDataGeneration
    {
        public class NullArrayFactory<T> : IEnumerable<object[]>
            where T : class
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[]
                {
                    CreateMockArray(1)
                };

                yield return new object[]
                {
                    CreateMockArray(5)
                };

                yield return new object[]
                {
                    CreateMockArray(10)
                };
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            private T[] CreateMockArray(int numberOfMocks)
            {
                var arr = new T[numberOfMocks];

                for (var i = 0; i < numberOfMocks; i++) arr[i] = null;

                return arr;
            }
        }

        public class NullFactory<T> : IEnumerable<object[]>
            where T : class
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[]
                {
                    default(T)
                };
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }


        public class MockArrayFactory<T> : IEnumerable<object[]>
            where T : class
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[]
                {
                    CreateMockArray(1)
                };

                yield return new object[]
                {
                    CreateMockArray(5)
                };

                yield return new object[]
                {
                    CreateMockArray(10)
                };
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            private Mock<T>[] CreateMockArray(int numberOfMocks)
            {
                var arr = new Mock<T>[numberOfMocks];

                for (var i = 0; i < numberOfMocks; i++) arr[i] = new Mock<T>();

                return arr;
            }
        }
    }
}