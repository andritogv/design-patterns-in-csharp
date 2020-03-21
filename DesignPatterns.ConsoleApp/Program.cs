using DesignPatterns.ConsoleApp.PrototypePattern;
using DesignPatterns.ConsoleApp.SingletonPattern;
using static System.Console;

namespace DesignPatterns.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SingletonDemo.DoDemo();
            PrototypeDemo.DoDemo();

            ReadKey();
        }
    }
}