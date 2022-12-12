using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexValidation1
{
    internal class Patterns
    {
        public static string Regex_Pincode = "^[1-9]*[0-9]{5}$";
        public bool validatePincode(string pincode)
        {
            bool status;
            Regex regex = new Regex(Regex_Pincode);
            if (regex.IsMatch(pincode))
            {
                status = true;
                return status;

            }
            else
            {
                status = false;
                
            }
            return status;
            
        }
    }
}
