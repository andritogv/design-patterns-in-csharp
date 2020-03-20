using DesignPatterns.Core.SingletonPattern;
using static System.Console;

namespace DesignPatterns.ConsoleApp.SingletonPattern
{
    public class SingletonDemo
    {
        public static void DoDemo()
        {
            WriteLine("*** Singleton Demo ***");

            WriteLine("Trying to create instance s1.");
            var s1 = Singleton.Instance;
            
            WriteLine("Trying to create instance s2.");
            var s2 = Singleton.Instance;

            if (s1 == s2)
            {
                WriteLine("Only one instance exists.");
            }
            else
            {
                WriteLine("There is more than one instance.");
            }
        }
    }
}