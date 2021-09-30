namespace JAP_Task_Backend.Models
{
    public class TopTenMoviesByRatings
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int RatingCount { get; set; }
        public int Rating { get; set; }
    }
}
