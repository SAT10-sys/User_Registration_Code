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
            if(checkFirstName==true)
                Console.WriteLine("FIRST NAME: "+firstName);
            else
            {
                Console.WriteLine("Please enter valid first name");
                goto RegStart1;
            }
        }
    }
}
