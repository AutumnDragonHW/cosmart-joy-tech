using System;
using System.Collections.Generic;
using System.Text;

namespace CosMart.JoyTech.Repository.Books
{
    public class SubjectDataModel
    {
        public string Name { get; set; }
        public string SubjectType { get; set; }
        public int WorkCount { get { return Works.Count; } }
        public List<BookModel> Works { get; set; }
        public int EbookCount { get; set; }
        public List<SubjectDataSubjectModel> Subjects { get; set; }
        public List<SubjectDataPlaceModel> Places { get; set; }
        public List<SubjectDataPeopleModel> People { get; set; }
        public List<SubjectDataTimeModel> Times { get; set; }
        public List<SubjectDataAuthorModel> Authors { get; set; }
        public List<SubjectDataPublisherModel> Publishers { get; set; }
        public List<SubjectDataLanguageModel> Languages { get; set; }
        public List<List<int>> PublishingHistory { get; set; }
    }

    public class SubjectDataSubjectModel
    {
        public string Key { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
    }

    public class SubjectDataPlaceModel
    {
        public string Key { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
    }

    public class SubjectDataPeopleModel
    {
        public string Key { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
    }

    public class SubjectDataTimeModel
    {
        public string Key { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
    }

    public class SubjectDataAuthorModel
    {
        public string Key { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
    }

    public class SubjectDataPublisherModel
    {
        public string Key { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
    }

    public class SubjectDataLanguageModel
    {
        public string Name { get; set; }
        public int Count { get; set; }
    }
}
