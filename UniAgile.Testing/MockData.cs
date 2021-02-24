using System;
using Moq;

namespace UniAgile.Testing
{
    public static class MockData
    {
        public static Mock<Func<T>> function_which_returns<T>()
            where T : new()
        {
            var mock = new Mock<Func<T>>();
            
            mock.which_returns();

            return mock;
        }
        
        public static Mock<Func<T>> function_which_returns<T>(Func<T> factory)
        {
            var mock = new Mock<Func<T>>();
            
            mock.which_returns(factory);

            return mock;
        }
    }
}