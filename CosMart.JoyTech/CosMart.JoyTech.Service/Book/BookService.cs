using AutoMapper;
using CosMart.JoyTech.Repository.Books;
using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
