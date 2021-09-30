using System;
using System.Collections.Generic;

namespace JAP_Task_Backend.DTO
{
    public class VideoDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ImageUrl { get; set; }
        public List<string> Actors { get; set; }
        public double Rating { get; set; }
    }
}
