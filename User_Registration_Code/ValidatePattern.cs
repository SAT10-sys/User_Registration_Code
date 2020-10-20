using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration_Code
{
    public class ValidatePattern
    {
        public string NAME = "^[A-Z][A-Za-z]{2,}$";
        public string EMAIL = "^[a-z0-9A-Z]+([._+-][a-z0-9A-Z]+)?[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        public string PHONE_NO = "^[1-9]{2} [1-9]{1}[0-9]{9}$";
        public string PASSWORD = "^(?=.*[A-Z])(?=.*[0-9])[a-zA-Z0-9!@#$%^&*()]{8,}$";
        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, NAME);
        }
        public bool ValidateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, NAME);
        }
        public bool ValidateEmailID(string emailID)
        {
            return Regex.IsMatch(emailID, EMAIL);
        }
        public bool ValidateMobileNumber(string phoneNo)
        {
            return Regex.IsMatch(phoneNo, PHONE_NO);
        }
        public bool ValidatePassword(string passWord)
        {
            return Regex.IsMatch(passWord, PASSWORD);
        }
    }
}
