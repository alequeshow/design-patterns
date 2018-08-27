using System;

namespace DesignPatterns.Singleton
{
    ///Since implementing a singleton is easy, you have a different challenge:
    ///Write a method called IsSingleton();
    ///This method takes a factory method that returns an object and it's up to you to determine 
    /// whether or not that object is a singleton instance
    public class SingletonTester
    {
        public static bool IsSingleton(Func<object> func)
        {
            var value1 = func();
            var value2 = func();

            return Object.ReferenceEquals(value1, value2);            
        }
    }
}