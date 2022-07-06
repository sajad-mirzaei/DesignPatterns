using Singleton.Struct1;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            SingletonClass s1 = SingletonClass.GetInstance();
            SingletonClass s2 = SingletonClass.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }
        }
    }
}