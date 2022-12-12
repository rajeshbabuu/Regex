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

        }
    }
}