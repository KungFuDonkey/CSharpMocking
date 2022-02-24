

namespace MockingByConstructor
{
    public class ExampleClass
    {
        private MyInterface _classToBeMocked;

        /// <summary>
        /// Standard constructor
        /// </summary>
        public ExampleClass()
        {
            _classToBeMocked = new MyClass();
        }


        public int Function()
        {
            return _classToBeMocked.GetResult();
        }
        /// <summary>
        /// Test constructor
        /// </summary>
        /// <param name="mock"></param>
        internal ExampleClass(MyInterface mock)
        {
            _classToBeMocked = mock;
        }
    }
}