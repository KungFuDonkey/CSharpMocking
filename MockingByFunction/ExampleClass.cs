

namespace MockingByFunction
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

        internal void SetMyInterface(MyInterface mock)
        {
            _classToBeMocked = mock;
        }
    }
}