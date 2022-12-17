using System;
using System.Collections.Generic;
using System.Text;

namespace CosMart.JoyTech.Service.Book.Response
{
    public class SubjectResponseDto
    {
        public string Key { get; set; }
        public string Name { get; set; }
        public string SubjectType { get; set; }
        public int WorkCount { get { return Works.Count; } }
        public List<BookDto> Works { get; set; }
    }

    public class SubjectResponseWithDetailDto : SubjectResponseDto
    {
        public int EbookCount { get; set; }
        public List<SubjectDataSubjectDto> Subjects { get; set; }
        public List<SubjectDataPlaceDto> Places { get; set; }
        public List<SubjectDataPeopleDto> People { get; set; }
        public List<SubjectDataTimeDto> Times { get; set; }
        public List<SubjectDataAuthorDto> Authors { get; set; }
        public List<SubjectDataPublisherDto> Publishers { get; set; }
        public List<SubjectDataLanguageDto> Languages { get; set; }
        public List<List<int>> PublishingHistory { get; set; }
    }


    public class SubjectDataSubjectDto
    {
        public string Key { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
    }

    public class SubjectDataPlaceDto
    {
        public string Key { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
    }

    public class SubjectDataPeopleDto
    {
        public string Key { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
    }

    public class SubjectDataTimeDto
    {
        public string Key { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
    }

    public class SubjectDataAuthorDto
    {
        public string Key { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
    }

    public class SubjectDataPublisherDto
    {
        public string Key { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
    }

    public class SubjectDataLanguageDto
    {
        public string Name { get; set; }
        public int Count { get; set; }
    }
}
