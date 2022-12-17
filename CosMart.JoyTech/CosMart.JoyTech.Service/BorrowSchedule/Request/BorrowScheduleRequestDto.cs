using System;
using System.Collections.Generic;
using System.Text;

namespace CosMart.JoyTech.Service.BorrowSchedule.Request
{
    public class BorrowScheduleRequestDto
    {
        public string BookId { get; set; }
        public DateTime ScheduleDate { get; set; }
        public string Username { get; set; }
    }
}
