using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class UserEntries
    {
        public static bool IsValidName(string firstName)
        {
            string namePattern = @"^[A-Z][a-z][a-z]+$"; //Pattern for Capital letter followed by small letters, min length 3
            Regex regex = new Regex(namePattern);
            if (regex.IsMatch(firstName))
            {
                return true;
            }
            throw new UserEntriesException(UserEntriesException.ExceptionType.NAME,"Enter Valid Name!");
        }

        public static bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9]+([.+-]{1}[A-Za-z0-9]+)*[@][a-zA-Z0-9]+([.]{1}([a-zA-Z]{2}|[a-zA-Z]{3,})){0,2}$";
            Regex regex = new Regex(emailPattern);
            if (regex.IsMatch(email))
            {
                return true;
            }
            throw new UserEntriesException(UserEntriesException.ExceptionType.EMAIL, "Enter Valid Email!");
        }

        public static bool IsValidMobileNumber(string mobileNumber)
        {
            string mobileNumberPattern = @"^[1-9][0-9][ ][1-9][0-9]{9}$";
            Regex regex = new Regex(mobileNumberPattern);
            if (regex.IsMatch(mobileNumber))
            {
                return true;
            }
            throw new UserEntriesException(UserEntriesException.ExceptionType.MOBILE_NUMBER, "Enter Valid Mobile Number!");
        }

        public static bool IsValidPassword(string password)
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
            throw new UserEntriesException(UserEntriesException.ExceptionType.PASSWORD, "Enter Valid Password!");
        }
    }
}
