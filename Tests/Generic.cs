using NUnit.Framework;
using MockingByGenerics;

namespace Tests
{
    public class Generic
    {
        class Mock : MyInterface
        {

        }
        [Test]
        public void Test1()
        {
            ExampleClass<Mock> e = new ExampleClass<Mock>(() => new Mock());
        }
    }
}
