using System;
using System.Text.RegularExpressions;

namespace _08_UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^[A-Z][a-z][a-z]+$"; //Pattern for Capital letter followed by small letters, min length 3
            Regex regex = new Regex(pattern);
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1. Check either First Name is valid or not \n2. Exit");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.WriteLine("Enter First Name");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("{0}",regex.IsMatch(firstName)?"Valid":"Invalid"); // Ternary operator
                        break;
                    default:
                        flag = false; // To break loop
                        break;
                }

            }
        }
    }
}
