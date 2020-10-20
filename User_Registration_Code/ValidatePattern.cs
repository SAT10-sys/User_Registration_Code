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
        public string PASSWORD = "^(?=.*[A-Z])(?=.*[0-9])(?=^[a-zA-Z0-9]*[!@#$%^&*()][a-zA-Z0-9]*$).{8,}$";
        public string ValidateFirstName(string firstName)
        {
            if (Regex.IsMatch(firstName, NAME))
                return "FIRST NAME IS VALID";
            else
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_FIRST_NAME, "First Name Is Invalid");
        }   
        public string ValidateLastName(string lastName)
        {
            if (Regex.IsMatch(lastName, NAME))
                return "LAST NAME IS VALID";
            else
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_LAST_NAME, "Last Name Is Invalid");
        }
        public string ValidateEmailID(string emailID)
        {
            if (Regex.IsMatch(emailID, EMAIL))
                return "EMAIL ID IS VALID";
            else
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_EMAIL, "Email ID Is Invalid");
        }
        public string ValidateMobileNumber(string phoneNo)
        {
            if (Regex.IsMatch(phoneNo, PHONE_NO))
                return "MOBILE NUMBER IS VALID";
            else
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_PHONENO, "Mobile Number Is Invalid");
        }
        public string ValidatePassword(string passWord)
        {
            if (Regex.IsMatch(passWord, PASSWORD))
                return "PASSWORD IS VALID";
            else
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_PASSWORD, "Password Is Invalid");
        }
    }
}
