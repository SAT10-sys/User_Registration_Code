using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration_Code
{
    public class ValidatePattern
    {
        public string FIRST_NAME = "^[A-Z][A-Za-z]{2,}$";
        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, FIRST_NAME);
        }
    }
}
