using Proxy.Struct1;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            Console.WriteLine("Client: Executing the client code with a real subject:");
            RealSubject realSubject = new RealSubject();
            client.ClientCode(realSubject);

            Console.WriteLine();

            Console.WriteLine("Client: Executing the same client code with a proxy:");
            ProxyClass proxy = new ProxyClass(realSubject);
            client.ClientCode(proxy);
        }
    }
}