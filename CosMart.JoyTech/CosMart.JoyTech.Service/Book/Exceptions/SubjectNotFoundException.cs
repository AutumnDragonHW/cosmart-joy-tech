using System;
using System.Collections.Generic;
using System.Text;

namespace CosMart.JoyTech.Service.Book.Exceptions
{
    public class SubjectNotFoundException : Exception
    {
        public SubjectNotFoundException() : base()
        {
        }
        public SubjectNotFoundException(string message) : base(message)
        {
        }

        public SubjectNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
