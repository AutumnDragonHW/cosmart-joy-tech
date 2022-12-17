using CosMart.JoyTech.Repository.Books;
using System;
using System.Collections.Generic;
using System.Text;

namespace CosMart.JoyTech.Repository.BorrowSchedules
{
    public class BorrowScheduleModel
    {
        public string BookId { get; set; }
        public DateTime ScheduleDate { get; set; }
        public BookModel BookInfo { get; set; }
        public string Username { get; set; }
    }
}
