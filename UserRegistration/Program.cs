using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInput();
        }

        static void UserInput()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1. Validate First Name \n2. Validate Last Name\n3. Validate Email " +
                                    "\n4. Validate Mobile Number \n5. Validate Password \n6. Exit");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.WriteLine("Enter First Name");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("{0}", UserEntries.IsValidName(firstName) ? "Valid" : "Invalid"); // Ternary operator
                        break;
                    case "2":
                        Console.WriteLine("Enter Last Name");
                        string lastName = Console.ReadLine();
                        Console.WriteLine("{0}", UserEntries.IsValidName(lastName) ? "Valid" : "Invalid"); // Ternary operator
                        break;
                    case "3":
                        Console.WriteLine("Enter Email");
                        string email = Console.ReadLine();
                        Console.WriteLine("{0}", UserEntries.IsValidEmail(email) ? "Valid" : "Invalid"); // Ternary operator
                        break;
                    case "4":
                        Console.WriteLine("Enter Mobile Number");
                        string mobileNumber = Console.ReadLine();
                        Console.WriteLine("{0}", UserEntries.IsValidMobileNumber(mobileNumber) ? "Valid" : "Invalid"); // Ternary operator
                        break;
                    case "5":
                        Console.WriteLine("Enter Password");
                        string password = Console.ReadLine();
                        Console.WriteLine("{0}", UserEntries.IsValidPassword(password) ? "Valid" : "Invalid"); // Ternary operator
                        break;
                    default:
                        flag = false; // To break loop
                        break;
                }
            }
        }
    }
}
