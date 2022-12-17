using CosMart.JoyTech.Service.Book;
using System;
using System.Collections.Generic;
using System.Text;

namespace CosMart.JoyTech.Service.BorrowSchedule
{
    public class BorrowScheduleDto
    {
        public string BookId { get; set; }
        public DateTime ScheduleDate { get; set; }
        public BookDto BookInfo { get; set; }
        public string Username { get; set; }
    }
}
