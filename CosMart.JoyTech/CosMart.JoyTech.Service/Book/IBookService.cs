using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CosMart.JoyTech.Service.Book
{
    public interface IBookService
    {
        Task<BookDto> GetBook(string bookId);
    }
}
