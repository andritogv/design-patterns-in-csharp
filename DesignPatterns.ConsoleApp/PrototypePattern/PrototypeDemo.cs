using DesignPatterns.Core.PrototypePattern;
using static System.Console;

namespace DesignPatterns.ConsoleApp.PrototypePattern
{
    public class PrototypeDemo
    {
        public static void DoDemo()
        {
            WriteLine("*** Prototype Demo ***");
            
            var basePrototype = new Prototype(5, 3.5);

            var clonedObject = basePrototype.Clone();

            clonedObject.IntValueProperty = 10;
            clonedObject.DoubleValueProperty = 5;
            
            WriteLine($"Int property for prototype is: {basePrototype.IntValueProperty}");
            WriteLine($"Double property for prototype is: {basePrototype.DoubleValueProperty}");
            WriteLine($"Int property for clone is: {clonedObject.IntValueProperty}");
            WriteLine($"Double property for clone is: {clonedObject.DoubleValueProperty}");
        }
    }
}