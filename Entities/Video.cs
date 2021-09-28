using JAP_Task_Backend.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public List<VideoActor> Actors { get; set; }
        public List<Rating> Ratings { get; set; }
    


    }
}
