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

            string pattern2 = @"^[1-9]{1}[0-9]{2}\s{0,1}[0-9]{3}";

            Regex rgSpaces = new Regex(pattern2);
            bool result2 = rgSpaces.IsMatch("400088");
            Console.WriteLine("Spaces between number " + result2);

            Console.WriteLine("\n\n============== WELCOME TO REGEX EMAIL PROGRAM ==============\n\n");

            string emailPattern = @"^[a-z A-Z]+([.][a-z A-Z]+)*@[a-z A-Z]+.[a-z A-Z]{2,10}([.][a-z A-Z]{2,3})?$";
            Regex em = new Regex(emailPattern);
            bool emresult = em.IsMatch("abc.xyz@bridgelabz.co.in");
            bool emresult1 = em.IsMatch("abc@bridgelabz.co");
            //Console.WriteLine("first uc of email is : " + emresult);
            Console.WriteLine("Without used Manadatory : " + emresult1);

            Console.WriteLine("\n Second UC : " + emresult1);

        }
    }
}