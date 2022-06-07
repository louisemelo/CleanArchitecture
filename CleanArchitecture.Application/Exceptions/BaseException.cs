using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Exceptions
{
    public class BaseException : Exception
    {
        public string Messages { get; set; }
        
        public BaseException(string messages)
        {
            Messages = messages;
        }
    }
}
