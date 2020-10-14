using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration
{
    public class UserEntriesException : Exception
    {
        public enum ExceptionType
        {
            NAME,
            EMAIL,
            MOBILE_NUMBER,
            PASSWORD
        }
        ExceptionType type;
        public UserEntriesException(ExceptionType type, string message):base(message)
        {
            this.type = type;
        }
    }
}
