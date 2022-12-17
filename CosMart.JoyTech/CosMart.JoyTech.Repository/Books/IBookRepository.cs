using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CosMart.JoyTech.Repository.Books
{
    public interface IBookRepository
    {
        Task<BookModel> GetBook(string id);
        Task<SubjectDataModel> GetData(string subject);
    }
}
