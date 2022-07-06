using State.Struct1;
using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            var context1 = new Context(new ConcreteStateA());
            context1.Request1();
            context1.Request2();
            Console.WriteLine(Environment.NewLine);
            var context2 = new Context(new ConcreteStateB());
            context2.Request1();
            context2.Request2();
        }
    }
}