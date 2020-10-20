using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration_Code
{
    public class ValidatePattern
    {
        public string NAME = "^[A-Z][A-Za-z]{2,}$";
        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, NAME);
        }
        public bool ValidateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, NAME);
        }
    }
}
