using System;

namespace JAP_Task_Backend.Models
{
    public class Screening
    {
        public int Id { get; set; }
        public int VideoId { get; set; }
        public Video Video { get; set; }
        public DateTime DateAndTime{get; set;}
        public int AvailableTickets { get; set; }
        public int SoldTickets { get; set; }
    }
}


