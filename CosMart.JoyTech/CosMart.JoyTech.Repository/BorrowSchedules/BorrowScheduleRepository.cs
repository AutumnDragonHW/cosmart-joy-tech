using CosMart.JoyTech.Repository.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosMart.JoyTech.Repository.BorrowSchedules
{
    public class BorrowScheduleRepository : IBorrowScheduleRepository
    {
        private readonly IBookRepository bookRepository;
        private IList<BorrowScheduleModel> borrowScheduleData;

        public BorrowScheduleRepository(IBookRepository bookRepository)
        {
            borrowScheduleData = new List<BorrowScheduleModel>();
            this.bookRepository = bookRepository;
        }

        public async Task AddBorrowSchedule(BorrowScheduleModel borrowSchedule)
        {
            borrowSchedule.ScheduleDate = borrowSchedule.ScheduleDate.Date;
            borrowScheduleData.Add(borrowSchedule);
        }

        public async Task<List<BorrowScheduleModel>> GetBorrowSchedule(DateTime date)
        {
            List<BorrowScheduleModel> borrowSchedules = new List<BorrowScheduleModel>();
            borrowSchedules = borrowScheduleData
                .Where(r => r.ScheduleDate == date)
                .ToList();
            foreach(var schedule in borrowSchedules)
            {
                schedule.BookInfo = await bookRepository.GetBook(schedule.BookId);
            }
            return borrowSchedules;
        }

        public async Task<List<BorrowScheduleModel>> GetBorrowSchedule(string bookId)
        {
            List<BorrowScheduleModel> borrowSchedules = new List<BorrowScheduleModel>();
            borrowSchedules = borrowScheduleData
                .Where(r => r.BookId == bookId)
                .ToList();
            foreach (var schedule in borrowSchedules)
            {
                schedule.BookInfo = await bookRepository.GetBook(schedule.BookId);
            }
            return borrowSchedules;
        }
    }
}
