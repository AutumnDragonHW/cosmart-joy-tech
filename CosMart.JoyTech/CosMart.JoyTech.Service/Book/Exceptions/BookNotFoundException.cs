using System;
using System.Collections.Generic;
using System.Text;

namespace CosMart.JoyTech.Service.Book.Exceptions
{
    public class BookNotFoundException : Exception
    {
        public BookNotFoundException(string message) : base(message)
        {
        }

        public BookNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
