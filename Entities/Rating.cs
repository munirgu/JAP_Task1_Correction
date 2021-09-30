using JAP_Task_Backend.Entities;

namespace JAP_Task_Backend.Models
{
    public class Rating
    {
        public int Id { get; set; }
        public int VideoId { get; set; }
        public Video Video { get; set; }
        public int Score { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
    }
}
