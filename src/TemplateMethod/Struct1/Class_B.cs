namespace TemplateMethod.Struct1
{
    /// <summary>
    /// Implements the primitive operations ot carry out subclass-specific steps of the algorithm.
    /// </summary>
    public class Class_B : Abstract1
    {
        protected override void RequiredOperation()
        {
            Console.WriteLine("ConcreteClassB call RequiredOperation() ***");
            Console.WriteLine($"property1: {Property1}");
            Property1 = 2;
            Console.WriteLine($"property1: {Property1}");
        }

        protected override void Hook()
        {
            Console.WriteLine("ConcreteClassB call Hook() ***");
        }
    }
}
