using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex
{
    internal class Patterns
    {
        public static string Regex_Pincode = "^[1-9][0-9]{5}$";
        public bool validatePincode(string pincode)
        {
            
            return Regex.IsMatch(pincode, Regex_Pincode);
        }
    }
}
