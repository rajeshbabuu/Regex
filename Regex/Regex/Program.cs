using Regex;

namespace Regex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============== WELCOME TO REGEX PROGRAM ==============");

            

            Patterns pattern = new Patterns();
            bool result=pattern.validatePincode("400088");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}