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
                Console.WriteLine("1. Validate First Name \n2. Validate Last Name\n3. Validate Email \n4. Validate Mobile Number \n5. Validate Password \n6. Exit");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.WriteLine("Enter First Name");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("{0}",IsValidFirstName(firstName)?"Valid":"Invalid"); // Ternary operator
                        break;
                    case "2":
                        Console.WriteLine("Enter Last Name");
                        string lastName = Console.ReadLine();
                        Console.WriteLine("{0}", IsValidLastName(lastName) ? "Valid" : "Invalid"); // Ternary operator
                        break;
                    case "3":
                        Console.WriteLine("Enter Email");
                        string email = Console.ReadLine();
                        Console.WriteLine("{0}", IsValidEmail(email) ? "Valid" : "Invalid"); // Ternary operator
                        break;
                    case "4":
                        Console.WriteLine("Enter Mobile Number");
                        string mobileNumber = Console.ReadLine();
                        Console.WriteLine("{0}", IsValidMobileNumber(mobileNumber) ? "Valid" : "Invalid"); // Ternary operator
                        break;
                    case "5":
                        Console.WriteLine("Enter Password");
                        string password = Console.ReadLine();
                        Console.WriteLine("{0}", IsValidPassword(password) ? "Valid" : "Invalid"); // Ternary operator
                        break;
                    default:
                        flag = false; // To break loop
                        break;
                }

            }
        }

        static bool IsValidFirstName(string firstName)
        {
            string pattern = @"^[A-Z][a-z][a-z]+$"; //Pattern for Capital letter followed by small letters, min length 3
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(firstName))
            {
                return true;
            }
            return false;
        }

        static bool IsValidLastName(string lastName)
        {
            string pattern = @"^[A-Z][a-z][a-z]+$"; //Pattern for Capital letter followed by small letters, min length 3
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(lastName))
            {
                return true;
            }
            return false;
        }

        static bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9]+[.A-Za-z0-9]*[@][a-zA-Z]+[.][a-zA-Z]+[.a-zA-Z]*$"; //Pattern for Capital letter followed by small letters, min length 3
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(email))
            {
                return true;
            }
            return false;
        }

        static bool IsValidMobileNumber(string mobileNumber)
        {
            string pattern = @"^[1-9][0-9][ ][1-9][0-9]{9}$"; 
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(mobileNumber))
            {
                return true;
            }
            return false;
        }

        static bool IsValidPassword(string password)
        {
            string pattern = @"^\w{8,}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(password))
            {
                return true;
            }
            return false;
        }
    }
}
