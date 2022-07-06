using TemplateMethod.Struct1;

namespace TemplateMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var menu = $"===== Template Method - design pattern ===== {Environment.NewLine}" +
                       $" **** Behavioral Pattern **** {Environment.NewLine}";
            Console.WriteLine(menu);

            var templateMethod = new TemplateMethod1();
            templateMethod.TryTemplateMethod();
        }
    }
}