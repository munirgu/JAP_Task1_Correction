using System;

namespace JAP_Task_Backend.Models
{
    public class TopMoviesByMostSoldTickets
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DateAndTime { get; set; }
        public int SoldTickets { get; set; }
    }
}
