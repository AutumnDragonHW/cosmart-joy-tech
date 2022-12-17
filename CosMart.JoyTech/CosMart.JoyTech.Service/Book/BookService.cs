using AutoMapper;
using CosMart.JoyTech.Repository.Books;
using CosMart.JoyTech.Service.Book.Exceptions;
using CosMart.JoyTech.Service.Book.Response;
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

        public async Task<SubjectResponseDto> GetDataBySubject(string subject)
        {
            var subjectData = mapper.Map<SubjectResponseDto>(await bookRepository.GetDataBySubject(subject));
            if (subjectData == null)
                throw new SubjectNotFoundException();
            var bookData = mapper.Map<List<BookDto>>(await bookRepository.GetBookBySubject(subject));
            subjectData.Works = bookData;
            return subjectData;
        }

        public async Task<SubjectResponseWithDetailDto> GetDataBySubjectWithDetail(string subject)
        {
            var subjectData = mapper.Map<SubjectResponseWithDetailDto>(await bookRepository.GetDataBySubject(subject));
            if (subjectData == null)
                throw new SubjectNotFoundException();
            var bookData = mapper.Map<List<BookDto>>(await bookRepository.GetBookBySubject(subject));
            subjectData.Works = bookData;

            // count subject, author, and publish history
            Dictionary<string, int> subjects = new Dictionary<string, int>();
            Dictionary<string, int> authors = new Dictionary<string, int>();
            Dictionary<string, AuthorDto> authorDatas = new Dictionary<string, AuthorDto>();
            Dictionary<int, int> publishHistory = new Dictionary<int, int>();
            foreach (var book in bookData)
            {
                foreach (var s in book.Subjects)
                {
                    if (subjects.ContainsKey(s))
                        subjects[s]++;
                    else
                        subjects.Add(s, 1);
                }
                foreach (var a in book.Authors)
                {
                    if (authors.ContainsKey(a.Key))
                        authors[a.Key]++;
                    else
                    {
                        authors.Add(a.Key, 1);
                        authorDatas.Add(a.Key, a);
                    }
                }
                var p = book.FirstPublishYear;
                if (publishHistory.ContainsKey(p))
                    publishHistory[p]++;
                else
                    publishHistory.Add(p, 1);
            }

            // add subjects
            foreach(var s in subjects)
            {
                SubjectDataSubjectDto subjectDataSubjectDto = new SubjectDataSubjectDto
                {
                    Name = s.Key,
                    Key = "/subjects/" + s.Key.ToLower().Replace(' ', '_'),
                    Count = s.Value
                };
                subjectData.Subjects.Add(subjectDataSubjectDto);
            }

            // add authors
            foreach(var a in authors)
            {
                SubjectDataAuthorDto subjectDataAuthorDto = new SubjectDataAuthorDto
                {
                    Key = a.Key,
                    Count = a.Value,
                    Name = authorDatas[a.Key].Name
                };
                subjectData.Authors.Add(subjectDataAuthorDto);
            }

            // add publish history
            foreach(var p in publishHistory)
            {
                List<int> ph = new List<int>();
                ph.Add(p.Key);
                ph.Add(p.Value);
                subjectData.PublishingHistory.Add(ph);
            }
            return subjectData;
        }
    }
}
