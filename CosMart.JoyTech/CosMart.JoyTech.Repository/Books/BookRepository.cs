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

        public async Task<List<BookModel>> GetBookBySubject(string subject)
        {
            return bookData.Where(r => r.Subjects.Contains(subject, StringComparer.OrdinalIgnoreCase)).ToList();
        }

        public async Task<SubjectDataModel> GetDataBySubject(string subject)
        {
            return subjectDataModels.Where(r => r.Name.Equals(subject, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
        }

        private void seedData()
        {
            SubjectDataModel subjectDataModel;
            subjectDataModel = new SubjectDataModel
            {
                Name = "love",
                SubjectType = "subject",
                EbookCount = 17,
                Languages = new List<SubjectDataLanguageModel>
                {
                    new SubjectDataLanguageModel
                    {
                        Name = "ita",
                        Count = 25
                    },
                    new SubjectDataLanguageModel
                    {
                        Name = "eng",
                        Count = 10
                    },
                    new SubjectDataLanguageModel
                    {
                        Name = "lat",
                        Count = 10
                    },
                    new SubjectDataLanguageModel
                    {
                        Name = "spa",
                        Count = 8
                    },
                }
            };

            subjectDataModels.Add(subjectDataModel);

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
                Subjects = new List<string>
                {
                    "Bibliography",
                    "British and irish drama (dramatic works by one author)",
                    "English Children's plays",
                    "Classical Literature",
                    "Conflicto entre generaciones",
                    "Conflict of generations",
                    "courtship",
                    "Criticism and interpretation",
                    "Drama",
                    "Drama inglés",
                    "Dramatic production",
                    "Enemistad mortal",
                    "English drama (collections), early modern and elizabethan, 1500-1600",
                    "English literature",
                    "English literature, study and teaching",
                    "English Love stories",
                    "English Young adult drama",
                    "Families",
                    "Fiction",
                    "History and criticism",
                    "Juvenile drama",
                    "Juvenile literature",
                    "Juventud",
                    "Language and linguistics",
                    "Literature",
                    "Love-Romance-Fiction",
                    "Love in adolescence",
                    "Man-woman relationships",
                    "Married people",
                    "open_syllabus_project",
                    "Performing Arts",
                    "Plays",
                    "Quartos",
                    "Reading Level-Grade 9",
                    "Reading Level-Grade 10",
                    "Reading Level-Grade 11",
                    "Reading Level-Grade 12",
                    "Shakespeare",
                    "Sources",
                    "Specimens",
                    "Stage history",
                    "Study guides",
                    "Suicide",
                    "Suspense-Fiction",
                    "Teatro",
                    "Tragedias",
                    "Tragedy",
                    "Vendetta",
                    "Youth",
                    "Shakespeare, william, 1564-1616",
                    "Shakespeare, william, 1564-1616, romeo and juliet",
                    "Shakespeare, william, 1564-1616, juvenile literature",
                    "Shakespeare, william, 1564-1616, criticism, textual",
                    "Shakespeare, william, 1564-1616, outlines, syllabi, etc.",
                    "Shakespeare, william, 1564-1616, dramatic production",
                    "Shakespeare, william, 1564-1616, stage history",
                    "Shakespeare, william, 1564-1616, criticism and interpretation",
                    "Drama, british and irish",
                    "Shakespeare, william, 1564-1616, adaptations",
                    "Critique et interprétation",
                    "Romeo and Juliet (Shakespeare, William)",
                    "Romeo (Fictitious character)",
                    "Juliet (Fictitious character)",
                    "English drama",
                    "Love",
                    "Adaptations",
                    "Comics & graphic novels, literary",
                    "Drama, collections",
                    "Translations",
                    "Tragedies",
                    "Man-woman relationship",
                    "Spanish language",
                    "Motion picture plays",
                    "Romeo and Juliet",
                    "Traducciones al español",
                    "18.05 English literature",
                    "Examinations",
                    "Fiction, general",
                    "Vendetta -- Drama",
                    "Youth -- Drama",
                    "Verona (Italy) -- Drama",
                    "Juliet (Fictitious character) -- Drama",
                    "Romeo (Fictitious character) -- Drama",
                    "Conflict of generations -- Drama",
                    "English drama (Tragedy)",
                    "Translations into Spanish",
                    "Early modern and Elizabethan",
                    "Teatro inglés (Tragedia)",
                    "Literatura inglesa",
                    "Theater",
                    "Aufführung",
                    "Geschichte",
                    "Drama (dramatic works by one author)",
                    "Caricatures and cartoons",
                    "Cartoons and comics",
                    "Caricatures et dessins humoristiques",
                    "Children's plays"
                },
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
