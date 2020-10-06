﻿using System;
using System.Text.RegularExpressions;

namespace _08_UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1. Validate First Name \n2. Validate Last Name\n3. Exit");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.WriteLine("Enter First Name");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("{0}",isValidFirstName(firstName)?"Valid":"Invalid"); // Ternary operator
                        break;
                    case "2":
                        Console.WriteLine("Enter Last Name");
                        string lastName = Console.ReadLine();
                        Console.WriteLine("{0}", isValidLastName(lastName) ? "Valid" : "Invalid"); // Ternary operator
                        break;
                    default:
                        flag = false; // To break loop
                        break;
                }

            }
        }

        static bool isValidFirstName(string firstName)
        {
            string pattern = @"^[A-Z][a-z][a-z]+$"; //Pattern for Capital letter followed by small letters, min length 3
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(firstName))
            {
                return true;
            }
            return false;
        }

        static bool isValidLastName(string lastName)
        {
            string pattern = @"^[A-Z][a-z][a-z]+$"; //Pattern for Capital letter followed by small letters, min length 3
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(lastName))
            {
                return true;
            }
            return false;
        }
    }
}
