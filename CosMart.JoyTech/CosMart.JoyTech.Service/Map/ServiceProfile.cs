using AutoMapper;
using CosMart.JoyTech.Repository.Books;
using CosMart.JoyTech.Repository.BorrowSchedules;
using CosMart.JoyTech.Service.Book;
using CosMart.JoyTech.Service.Book.Response;
using CosMart.JoyTech.Service.BorrowSchedule;
using CosMart.JoyTech.Service.BorrowSchedule.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace CosMart.JoyTech.Service.Map
{
    public class ServiceProfile : Profile
    {
        public ServiceProfile()
        {
            CreateMap<BookModel, BookDto>().ReverseMap();
            CreateMap<BookDto, BookWorksResponseDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => "/works/" + src.Id));
            CreateMap<BookAvailabilityModel, BookAvailabilityDto>().ReverseMap();
            CreateMap<AuthorModel, AuthorDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => "/authors/" + src.Id));

            CreateMap<BorrowScheduleModel, BorrowScheduleDto>().ReverseMap();
            CreateMap<BorrowScheduleRequestDto, BorrowScheduleDto>();

            CreateMap<SubjectDataModel, SubjectResponseDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => "/subjects/" + src.Name));
            CreateMap<SubjectDataModel, SubjectResponseWithDetailDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => "/subjects/" + src.Name));
            CreateMap<SubjectDataSubjectModel, SubjectDataSubjectDto>();
            CreateMap<SubjectDataPlaceModel, SubjectDataPlaceDto>();
            CreateMap<SubjectDataPeopleModel, SubjectDataPeopleDto>();
            CreateMap<SubjectDataTimeModel, SubjectDataTimeDto>();
            CreateMap<SubjectDataAuthorModel, SubjectDataAuthorDto>();
            CreateMap<SubjectDataPublisherModel, SubjectDataPublisherDto>();
            CreateMap<SubjectDataLanguageModel, SubjectDataLanguageDto>();
        }
    }
}
