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
                Console.WriteLine("1. Validate First Name \n2. Validate Last Name\n3. Validate Email " +
                                    "\n4. Validate Mobile Number \n5. Validate Password \n6. Exit");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.WriteLine("Enter First Name");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("{0}",IsValidName(firstName)?"Valid":"Invalid"); // Ternary operator
                        break;
                    case "2":
                        Console.WriteLine("Enter Last Name");
                        string lastName = Console.ReadLine();
                        Console.WriteLine("{0}", IsValidName(lastName) ? "Valid" : "Invalid"); // Ternary operator
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

        static bool IsValidName(string firstName)
        {
            string namePattern = @"^[A-Z][a-z][a-z]+$"; //Pattern for Capital letter followed by small letters, min length 3
            Regex regex = new Regex(namePattern);
            if (regex.IsMatch(firstName))
            {
                return true;
            }
            return false;
        }

        static bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9]+([.+-]{1}[A-Za-z0-9]+)*[@][a-zA-Z0-9]+([.]{1}([a-zA-Z]{2}|[a-zA-Z]{3,})){0,2}$";
            Regex regex = new Regex(emailPattern);
            if (regex.IsMatch(email))
            {
                return true;
            }
            return false;
        }

        static bool IsValidMobileNumber(string mobileNumber)
        {
            string mobileNumberPattern = @"^[1-9][0-9][ ][1-9][0-9]{9}$"; 
            Regex regex = new Regex(mobileNumberPattern);
            if (regex.IsMatch(mobileNumber))
            {
                return true;
            }
            return false;
        }
        
        static bool IsValidPassword(string password)
        {
            // ?= is used for assertion, we want minimum one Capital letter and one small letter
            // .*[A-Z] means there must be one Capital letter in front of which there can be any number of characters
            // . stand for any character and * stand for 0 or more occurence
            string passwordPattern = @"^(?=.*[A-Z])(?=.*[0-9])(?=.*[a-z])(?=.*[@#$%_])(?!.*[@#$%_].*[@#$%_]).{8,20}$";
            Regex regex = new Regex(passwordPattern);
            if (regex.IsMatch(password))
            {
                return true;
            }
            return false;
        }
    }
}
