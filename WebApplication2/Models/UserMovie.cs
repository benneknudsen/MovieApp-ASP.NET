using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class UserMovie
    {
        public int userMovieId { get; set; }

        public int movieId { get; set; }
        public int userId { get; set; }

        public Movie Movie { get; set; }
        public User User { get; set; }
    }
}
