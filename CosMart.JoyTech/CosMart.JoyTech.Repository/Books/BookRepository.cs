using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosMart.JoyTech.Repository.Books
{
    public class BookRepository : IBookRepository
    {
        private IList<BookModel> bookData;
        private IList<SubjectDataModel> subjectDataModels;
        public BookRepository()
        {
            bookData = new List<BookModel>();
            subjectDataModels = new List<SubjectDataModel>();
            seedData();
        }

        public async Task<BookModel> GetBook(string id)
        {
            return bookData.Where(r => r.Id == id).FirstOrDefault();
        }

        public async Task<SubjectDataModel> GetData(string subject)
        {
            throw new NotImplementedException();
        }

        private void seedData()
        {
            SubjectDataModel subjectDataModel = new SubjectDataModel();

            BookModel bookModel;
            bookModel = new BookModel
            {
                Id = "OL362427W",
                Title = "Romeo and Juliet",
                EditionCount = 969,
                CoverId = 8257991,
                CoverEditionKey = "OL26501367M",
                LendingLibrary = false,
                PrintDisabled = true,
                LendingEdition = "OL23330725M",
                LendingIdentifier = "romeoundjulia00shakuoft",
                AuthorIds = new List<string> { "OL9388A" },
                Authors = new List<AuthorModel>
                {
                    new AuthorModel
                    {
                        Id = "OL9388A",
                        Name = "William Shakespeare"
                    }
                },
                FirstPublishYear = 1597,
                Ia = "romeoundjulia00shakuoft",
                PublicScan = true,
                HasFullText = true,
                Availability = new BookAvailabilityModel
                {
                    Status = "Open",
                    AvailabilityToBrowse = false,
                    AvailabilityToBorrow = false,
                    AvailabilityToWaitlist = false,
                    IsPrintDisabled = false,
                    IsReadable = true,
                    IsLendable = false,
                    IsPreviewable = true,
                    Identifier = "romeoundjulia00shakuoft",
                    OpenLibraryWork = "OL362427W",
                    OpenLibraryEdition = "OL23330725M"
                }
            };

            bookData.Add(bookModel);
        }
    }
}
