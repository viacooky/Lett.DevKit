using NUnit.Framework;

namespace Lett.DevKit.Common.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.IsTrue(new Class1().TestMethod("", ""));
        }
    }
}