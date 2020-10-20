using System;
using System.Collections.Generic;
using System.Text;

namespace User_Registration_Code
{
    public class UserRegistrationCustomException:Exception
    {
        public enum ExceptionType
        {
            INVALID_FIRST_NAME,
            INVALID_LAST_NAME,
            INVALID_EMAIL,
            INVALID_PHONENO,
            INVALID_PASSWORD
        }

        ExceptionType type;
        public UserRegistrationCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
