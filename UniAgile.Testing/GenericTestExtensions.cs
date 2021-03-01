using System;
using Moq;

namespace UniAgile.Testing
{
    public static class GenericTestExtensions
    {
        // public static void is_not_null<T>(this T param)
        // {
        //     Assert.NotNull(param);
        // }

        public static void which_returns<T>(this Mock<Func<T>> mock)
            where T : new()
        {
            mock.Setup(m => m.Invoke()).Returns(new T());
            
        }
        
        public static void which_returns<T>(this Mock<Func<T>> mock, Func<T> factory)
        {
            mock.Setup(m => m.Invoke()).Returns(factory());
        }
    }
}