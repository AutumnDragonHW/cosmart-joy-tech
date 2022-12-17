using System;
using System.Collections.Generic;
using System.Text;

namespace CosMart.JoyTech.Service.Book.Response
{
    public class BookWorksResponseDto
    {
        public string Key { get; set; }
        public string Title { get; set; }
        public int EditionCount { get; set; }
        public long CoverId { get; set; }
        public string CoverEditionKey { get; set; }
        public List<int> AuthorIds { get; set; }
        public List<string> IaCollections { get; set; }
        public List<string> Subjects { get; set; }
        public string Ia { get; set; }
        public bool HasFullText { get; set; }
        public bool PublicScan { get; set; }
        public bool LendingLibrary { get; set; }
        public bool PrintDisabled { get; set; }
        public string LendingEdition { get; set; }
        public string LendingIdentifier { get; set; }
        public BookAvailabilityDto Availability { get; set; }
        public int FirstPublishYear { get; set; }

        public List<AuthorDto> Authors { get; set; }
    }
}
