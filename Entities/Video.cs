using JAP_Task_Backend.Enums;
using System;
using System.Collections.Generic;

namespace JAP_Task_Backend.Models
{
    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public VideoType Type { get; set; }
        public string ImageUrl { get; set; }
        public List<Actor> Actors { get; set; }
        public List<Rating> Ratings { get; set; }
    }
}
