using TemplateMethod.Struct1;
using TemplateMethod.Struct2;

namespace TemplateMethod
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Template Method - Behavioral Pattern
            Console.WriteLine("----------Struct1------------");
            Struct1();
            Console.WriteLine("----------Struct2------------");
            Struct2();
        }
        public static void Struct1()
        {
            var templateMethod = new TemplateMethod1();
            templateMethod.TryTemplateMethod();
        }
        static void Struct2()
        {
            Console.WriteLine("Same client code can work with different subclasses:");

            Client.ClientCode(new ConcreteClass1());

            Console.Write("\n");

            Console.WriteLine("Same client code can work with different subclasses:");
            Client.ClientCode(new ConcreteClass2());
        }
    }
}