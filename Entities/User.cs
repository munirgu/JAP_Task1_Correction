using JAP_Task_Backend.Models;
using System.Collections.Generic;

namespace JAP_Task_Backend.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public List<Rating> Ratings { get; set; }
    }
}
