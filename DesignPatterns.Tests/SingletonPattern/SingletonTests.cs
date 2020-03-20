using DesignPatterns.Core.SingletonPattern;
using Xunit;

namespace DesignPatterns.Tests.SingletonPattern
{
    public class SingletonTests
    {
        [Fact]
        public void ThereIsOnlyOneInstance()
        {
            var s1 = Singleton.Instance;

            var s2 = Singleton.Instance;
            
            Assert.True(s1 == s2, "Instances are not the same.");
        }
    }
}