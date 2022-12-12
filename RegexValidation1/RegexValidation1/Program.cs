using System.Text.RegularExpressions;

namespace RegexValidation1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============== WELCOME TO REGEX PROGRAM ==============");



            Patterns pattern = new Patterns();
            bool result = pattern.validatePincode("400088");
            Console.WriteLine("PIN : " + result);

            bool alphabet_SpecialChar = pattern.validatePincode("A400088");
            Console.WriteLine("Alphabet : " + alphabet_SpecialChar);

            string pattern1 = @"^[1-9]{6}[A-Z]{7}$";

            Regex rgobj = new Regex(pattern1);
            bool result1 = rgobj.IsMatch("400088B");
            Console.WriteLine("Check not last alphabet " + result1);

        }
    }
}