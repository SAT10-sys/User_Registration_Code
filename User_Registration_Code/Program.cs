using System;

namespace User_Registration_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program");
            ValidatePattern validatePattern = new ValidatePattern();
        RegStart1:
            Console.WriteLine("Enter first name(should begin with capital letters and have minimum 3 letters)");
            string firstName = Console.ReadLine();
            bool checkFirstName = validatePattern.ValidateFirstName(firstName);
            Console.WriteLine("Enter last name(should begin with capital letters and have minimum 3 letters)");
            string lastName = Console.ReadLine();
            bool checkLastName = validatePattern.ValidateLastName(lastName);
            if (checkFirstName==true && checkLastName==true)
                Console.WriteLine("NAME: "+firstName+" "+lastName);
            else
            {
                Console.WriteLine("Please enter valid name");
                goto RegStart1;
            }
        RegStart2:
            Console.WriteLine("Enter Email ID");
            string emailID = Console.ReadLine();
            bool checkEmail = validatePattern.ValidateEmailID(emailID);
            if(checkEmail==true)
                Console.WriteLine("EMAIL ID: "+emailID);
            else
            {
                Console.WriteLine("Please enter valid email id");
                goto RegStart2;
            }
        RegStart3:
            Console.WriteLine("Enter Mobile Number in the following format--> country code, space, mobile number");
            string phoneNo = Console.ReadLine();
            bool checkPhoneNo = validatePattern.ValidateMobileNumber(phoneNo);
            if(checkPhoneNo==true)
                Console.WriteLine("MOBILE NUMBER: "+phoneNo);
            else
            {
                Console.WriteLine("Please enter valid phone number");
                goto RegStart3;
            }
        RegStart4:
            Console.WriteLine("Enter password(minimum 8 characters)");
            string passWord = Console.ReadLine();
            bool checkPassWord = validatePattern.ValidatePassword(passWord);
            if(checkPassWord==true)
                Console.WriteLine("PASSWORD: "+passWord);
            else
            {
                Console.WriteLine("Please enter valid password");
                goto RegStart4;
            }
        }
    }
}
