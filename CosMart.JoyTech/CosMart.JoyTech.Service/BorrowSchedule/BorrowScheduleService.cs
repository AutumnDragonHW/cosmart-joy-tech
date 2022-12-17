using AutoMapper;
using CosMart.JoyTech.Repository.Books;
using CosMart.JoyTech.Repository.BorrowSchedules;
using CosMart.JoyTech.Service.Book;
using CosMart.JoyTech.Service.BorrowSchedule.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CosMart.JoyTech.Service.BorrowSchedule
{
    public class BorrowScheduleService : IBorrowScheduleService
    {
        private readonly IMapper mapper;
        private readonly IBorrowScheduleRepository borrowScheduleRepository;
        private readonly IBookService bookService;

        public BorrowScheduleService(IMapper mapper, IBorrowScheduleRepository borrowScheduleRepository, IBookService bookService)
        {
            this.mapper = mapper;
            this.borrowScheduleRepository = borrowScheduleRepository;
            this.bookService = bookService;
        }

        public async Task ScheduleBorrowBook(BorrowScheduleDto borrowScheduleDto)
        {
            var book = await bookService.GetBook(borrowScheduleDto.BookId);
            await borrowScheduleRepository.AddBorrowSchedule(mapper.Map<BorrowScheduleModel>(borrowScheduleDto)).ConfigureAwait(false);
        }

        public async Task ScheduleBorrowBook(BorrowScheduleRequestDto borrowScheduleRequestDto)
        {
            await ScheduleBorrowBook(mapper.Map<BorrowScheduleDto>(borrowScheduleRequestDto));
        }

        public async Task<List<BorrowScheduleDto>> GetBorrowSchedule(DateTime date)
        {
            return mapper.Map<List<BorrowScheduleDto>>(await borrowScheduleRepository.GetBorrowSchedule(date.Date));
        }

        public async Task<List<BorrowScheduleDto>> GetBorrowSchedule(string bookId)
        {
            return mapper.Map<List<BorrowScheduleDto>>(await borrowScheduleRepository.GetBorrowSchedule(bookId));
        }
    }
}
