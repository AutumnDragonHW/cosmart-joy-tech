using CosMart.JoyTech.Service.BorrowSchedule.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CosMart.JoyTech.Service.BorrowSchedule
{
    public interface IBorrowScheduleService
    {
        Task<List<BorrowScheduleDto>> GetBorrowSchedule(DateTime date);
        Task<List<BorrowScheduleDto>> GetBorrowSchedule(string bookId);
        Task ScheduleBorrowBook(BorrowScheduleDto borrowScheduleDto);
        Task ScheduleBorrowBook(BorrowScheduleRequestDto borrowScheduleRequestDto);
    }
}
