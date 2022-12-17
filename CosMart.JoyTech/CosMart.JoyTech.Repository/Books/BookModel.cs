using System;
using System.Collections.Generic;
using System.Text;

namespace CosMart.JoyTech.Repository.Books
{
    public class BookModel
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public int EditionCount { get; set; }
        public long CoverId { get; set; }
        public string CoverEditionKey { get; set; }
        public List<string> AuthorIds { get; set; }
        public List<string> IaCollections { get; set; }
        public List<string> Subjects { get; set; }
        public string Ia { get; set; }
        public bool HasFullText { get; set; }
        public bool PublicScan { get; set; }
        public bool LendingLibrary { get; set; }
        public bool PrintDisabled { get; set; }
        public string LendingEdition { get; set; }
        public string LendingIdentifier { get; set; }
        public int FirstPublishYear { get; set; }

        public BookAvailabilityModel Availability { get; set; }

        public List<AuthorModel> Authors { get; set; }
    }

    public class BookAvailabilityModel
    {
        public string Status { get; set; }
        public bool AvailabilityToBrowse { get; set; }
        public bool AvailabilityToBorrow { get; set; }
        public bool AvailabilityToWaitlist { get; set; }
        public bool IsPrintDisabled { get; set; }
        public bool IsReadable { get; set; }
        public bool IsLendable { get; set; }
        public bool IsPreviewable { get; set; }
        public string Identifier { get; set; }
        public string Isbn { get; set; }
        public string Oclc { get; set; }
        public string OpenLibraryWork { get; set; }
        public string OpenLibraryEdition { get; set; }
        public DateTime LastLoanDate { get; set; }
        public int? NumWaitlist { get; set; }
        public DateTime LastWaitlistDate { get; set; }
        public bool IsRestricted { get; set; }
        public bool IsBrowsable { get; set; }
    }
}
