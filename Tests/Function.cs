using NUnit.Framework;
using MockingByFunction;

namespace Tests
{
    public class Function
    {
        class Mock : MyInterface
        {

        }

        [Test]
        public void Test1()
        {
            ExampleClass e = new ExampleClass();
            e.SetMyInterface(new Mock());
        }
    }
}
