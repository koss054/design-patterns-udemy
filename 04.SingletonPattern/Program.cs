using System;

namespace Coding.Exercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var testObject = new object();
            bool isSingleton = SingletonTester.IsSingleton(() => testObject);

            Console.WriteLine(isSingleton);
        }
    }

    public class SingletonTester
    {
        public static bool IsSingleton(Func<object> func)
        {
            var firstObject = func();
            var secondObject = func();

            return ReferenceEquals(firstObject, secondObject);
        }
    }
}
