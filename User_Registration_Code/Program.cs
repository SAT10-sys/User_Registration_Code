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
        }
    }
}
