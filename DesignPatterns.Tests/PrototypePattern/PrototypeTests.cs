using DesignPatterns.Core.PrototypePattern;
using Xunit;

namespace DesignPatterns.Tests.PrototypePattern
{
    public class PrototypeTests
    {
        [Fact]
        public void TestPrototype()
        {
            var basePrototype = new Prototype(5, 3.5);

            var clonedObject = basePrototype.Clone();

            clonedObject.IntValueProperty = 10;
            clonedObject.DoubleValueProperty = 5;
            
            Assert.NotEqual(basePrototype.IntValueProperty, clonedObject.IntValueProperty);
            Assert.NotEqual(basePrototype.DoubleValueProperty, clonedObject.DoubleValueProperty);
        }
    }
}