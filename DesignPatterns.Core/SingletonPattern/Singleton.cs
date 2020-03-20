using static System.Console;

namespace DesignPatterns.Core.SingletonPattern
{
    public sealed class Singleton
    {
        public static Singleton Instance { get; } = new Singleton();

        private int _numberOfInstances = 0;

        private Singleton()
        {
            WriteLine("Instantiating within private constructor");
            _numberOfInstances++;
            WriteLine($"Number of instances = {_numberOfInstances}");
        }
    }
}