namespace MockingByGenerics
{
    public class UseCase
    {
        private ExampleClass<MyClass> _example;

        public UseCase()
        {
            _example = new ExampleClass<MyClass>(() => new MyClass());
        }
    }
    public class ExampleClass<MyClass> where MyClass : MyInterface, new()
    {
        private MyClass _classToBeMocked;

        public ExampleClass()
        {
            _classToBeMocked = new MyClass();
        }
    }
}