namespace TemplateMethod.Struct1
{
    /// <summary>
    /// Concrete classes have to implement all abstract operations of the base class.
    /// They can also override some operations with a default implementation.
    /// </summary>
    public class Class_A : Abstract1
    {
        protected override void RequiredOperation()
        {
            Console.WriteLine(" - 'ConcreteClassA' call 'RequiredOperation' Concrete implementation!");
            Console.WriteLine($"property1: {Property1}");
            Property1 = 1;
            Console.WriteLine($"property1: {Property1}");
        }
    }
}
