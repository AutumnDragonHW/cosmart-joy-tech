using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CosMart.JoyTech.Repository.BorrowSchedules
{
    public interface IBorrowScheduleRepository
    {
        Task AddBorrowSchedule(BorrowScheduleModel borrowSchedule);
        Task<List<BorrowScheduleModel>> GetBorrowSchedule(DateTime date);
        Task<List<BorrowScheduleModel>> GetBorrowSchedule(string bookId);
    }
}
