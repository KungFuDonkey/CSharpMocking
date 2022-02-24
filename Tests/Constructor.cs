using NUnit.Framework;
using MockingByConstructor;




namespace Tests
{

    public class Constructor
    {
        class Mock : MyInterface
        {
            public int GetResult()
            {
                return 42;
            }
        }

        [Test]
        public void Test1()
        {
            ExampleClass e = new ExampleClass(new Mock());
            Assert.IsTrue(e.Function() == 42);
        }
    }
}