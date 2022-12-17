using AutoMapper;
using CosMart.JoyTech.Repository.Books;
using CosMart.JoyTech.Service.Book.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CosMart.JoyTech.Service.Book
{
    public class BookService : IBookService
    {
        private readonly IMapper mapper;
        private readonly IBookRepository bookRepository;

        public BookService(IMapper mapper, IBookRepository bookRepository)
        {
            this.mapper = mapper;
            this.bookRepository = bookRepository;
        }

        public async Task<BookDto> GetBook(string bookId)
        {
            var bookData = mapper.Map<BookDto>(await bookRepository.GetBook(bookId));
            if (bookData == null)
                throw new BookNotFoundException("Book ID is not found.");
            return bookData;
            
        }
    }
}
