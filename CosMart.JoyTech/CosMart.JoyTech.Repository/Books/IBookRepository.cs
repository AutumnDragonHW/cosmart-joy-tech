using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CosMart.JoyTech.Repository.Books
{
    public interface IBookRepository
    {
        Task<BookModel> GetBook(string id);
        Task<List<BookModel>> GetBookBySubject(string subject);
        Task<SubjectDataModel> GetDataBySubject(string subject);
    }
}
