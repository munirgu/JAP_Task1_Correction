using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JAP_Task_Backend.Models
{
    public class VideoActor
    {
        public int Id { get; set; }
        public int VideoId { get; set; }
        public Video Video { get; set; }
        public string Name { get; set; }
    }
}
