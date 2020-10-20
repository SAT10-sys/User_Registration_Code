using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Reflection.Metadata.Ecma335;

namespace User_Registration_Code
{
    public class ValidatePattern
    {
        const string FIRST_NAME = "^[A-Z][A-Za-z]{2,}$";
        const string LAST_NAME = "^[A-Z][A-Za-z]{2,}$";
        const string EMAIL = "^[a-z0-9A-Z]+([._+-][a-z0-9A-Z]+)?[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        const string PHONE_NO = "^[1-9]{2} [1-9]{1}[0-9]{9}$";
        const string PASSWORD = "^(?=.*[A-Z])(?=.*[0-9])(?=^[a-zA-Z0-9]*[!@#$%^&*()][a-zA-Z0-9]*$).{8,}$";
        public Func<string, string> ValidateFirstName = x => Regex.IsMatch(x, FIRST_NAME) ? "First Name is Valid" : throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_FIRST_NAME, "First Name is Invalid");
        public Func<string, string> ValidateLastName = x => Regex.IsMatch(x, LAST_NAME) ? "Last Name is Valid" : throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_LAST_NAME, "Last Name is Invalid");
        public Func<string, string> ValidateEmailID = x => Regex.IsMatch(x, EMAIL) ? "Email ID is Valid" : throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_EMAIL, "Email ID is invalid");
        public Func<string, string> ValidateMobileNumber = x => Regex.IsMatch(x, PHONE_NO) ? "Phone Number is Valid" : throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_PHONENO, "Phone Number is Invalid");
        public Func<string, string> ValidatePassword = x => Regex.IsMatch(x, PASSWORD) ? "Password is Valid" : throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_PASSWORD, "Password is Invalid");

    }
}
