using System;
using static System.Console;

namespace DesignPatterns.Core.SingletonPattern
{
    public class LazySingleton
    {
    
        private static Lazy<LazySingleton> instance = new Lazy<LazySingleton>(() => new LazySingleton());
        
        private LazySingleton()
        {
            WriteLine("Initializing instance");
        }

        public static LazySingleton Instance => instance.Value;
    }
}