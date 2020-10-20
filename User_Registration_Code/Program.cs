using System;

namespace User_Registration_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program");
            ValidatePattern validatePattern = new ValidatePattern();
            string result;
        RegStart1:
            try
            {
                Console.WriteLine("Enter first name(should begin with capital letters and have minimum 3 letters)");
                string firstName = Console.ReadLine();
                result = validatePattern.ValidateFirstName(firstName);
            }
            catch(UserRegistrationCustomException e)
            {
                Console.WriteLine(e.Message);
                goto RegStart1;
            }
        RegStart2:
            try
            {
                Console.WriteLine("Enter last name(should begin with capital letters and have minimum 3 letters)");
                string lastName = Console.ReadLine();
                result = validatePattern.ValidateLastName(lastName);
            }
            catch(UserRegistrationCustomException e)
            {
                Console.WriteLine(e.Message);
                goto RegStart2;
            }
        RegStart3:
            try
            {
                Console.WriteLine("Enter email Id");
                string emailId= Console.ReadLine();
                result = validatePattern.ValidateEmailID(emailId);
            }
            catch (UserRegistrationCustomException e)
            {
                Console.WriteLine(e.Message);
                goto RegStart3;
            }
        RegStart4:
            try
            {
                Console.WriteLine("Enter mobile number");
                string phoneNumber = Console.ReadLine();
                result = validatePattern.ValidateMobileNumber(phoneNumber);
            }
            catch (UserRegistrationCustomException e)
            {
                Console.WriteLine(e.Message);
                goto RegStart4;
            }
        RegStart5:
            try
            {
                Console.WriteLine("Enter Password(at least 1 capital letter, at least 1 digit, at most 1 special character and at least 8 characters overall)");
                string password = Console.ReadLine();
                result = validatePattern.ValidatePassword(password);
            }
            catch(UserRegistrationCustomException e)
            {
                Console.WriteLine(e.Message);
                goto RegStart5;
            }
        }
    }
}
