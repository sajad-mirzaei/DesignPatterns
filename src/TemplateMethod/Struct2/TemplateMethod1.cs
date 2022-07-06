using TemplateMethod.Struct2;

namespace TemplateMethod.Struct2
{
    public class TemplateMethod1
    {
        public void TryTemplateMethod()
        {
            //Console.WriteLine("Same client code can work with different subclasses:");
            //Console.WriteLine(" - 'ConcreteClassA' call 'TemplateMethod'");
            ClientCode(new Class_A());

            Console.WriteLine();
            //Console.WriteLine("Same client code can work with different subclasses:");
            ClientCode(new Class_B());
        }
        private void ClientCode(Abstract1 abstractClass)
        {
            abstractClass.TemplateMethod();
        }
    }
}
