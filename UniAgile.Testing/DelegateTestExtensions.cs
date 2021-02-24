using System;
using Moq;

namespace UniAgile.Testing
{
    public static class DelegateTestExtensions
    {
        private static void called(this Mock<Action> delegateMock)
        {
            delegateMock.Verify(listener => listener.Invoke(), Times.Exactly(1), "Delegate was not called. It was expected to be called");
        }

        public static void are_called_once(this Mock<Action>[] delegateMock)
        {
            foreach (var mock in delegateMock)
            {
                called(mock);
            }
        }
        
        public static void is_called_once(this Mock<Action> delegateMock)
        {
            called(delegateMock);
        }

        public static void is_not_called(this Mock<Action> delegateMock)
        {
            delegateMock.Verify(listener => listener.Invoke(), Times.Exactly(0), "Delegate was called. It was expected not to be called");
        }

        public static void are_not_called(this Mock<Action>[] delegateMocks)
        {
            foreach (var delegateMock in delegateMocks) delegateMock.is_not_called();
        }

        private static void called<T>(this Mock<Action<T>> delegateMock)
        {
            delegateMock.Verify(listener => listener.Invoke(It.IsAny<T>()), Times.Exactly(1), "Delegate was not called. It was expected to be called");
        }

        public static void are_called_once<T>(this Mock<Action<T>>[] delegateMock)
        {
            foreach (var mock in delegateMock)
            {
                called(mock);
            }
        }
        
        public static void is_called_once<T>(this Mock<Action<T>> delegateMock)
        {
            called(delegateMock);
        }

        public static void is_not_called<T>(this Mock<Action<T>> delegateMock)
        {
            delegateMock.Verify(listener => listener.Invoke(It.IsAny<T>()), Times.Exactly(0), "Delegate was called. It was expected not to be called");
        }

        public static void are_not_called<T>(this Mock<Action<T>>[] delegateMocks)
        {
            foreach (var delegateMock in delegateMocks) delegateMock.is_not_called();
        }

        private static void called<T>(this Mock<Func<T>> delegateMock)
        {
            delegateMock.Verify(listener => listener.Invoke(), Times.Exactly(1), "Delegate was not called. It was expected to be called");
        }

        public static void are_called_once<T>(this Mock<Func<T>>[] delegateMock)
        {
            foreach (var mock in delegateMock)
            {
                called(mock);
            }
        }
        
        public static void is_called_once<T>(this Mock<Func<T>> delegateMock)
        {
            called(delegateMock);
        }

        public static void is_not_called<T>(this Mock<Func<T>> delegateMock)
        {
            delegateMock.Verify(listener => listener.Invoke(), Times.Exactly(0), "Delegate was called. It was expected not to be called");
        }

        public static void are_not_called<T>(this Mock<Func<T>>[] delegateMocks)
        {
            foreach (var delegateMock in delegateMocks) delegateMock.is_not_called();
        }
        
    }
}