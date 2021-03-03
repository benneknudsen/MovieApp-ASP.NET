using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class HomeViewModel
    {
        public Page PopularMovies { get; set; }
        public Page UpcomingMovies { get; set; }

        public Page PopularTV { get; set; }

        public Page NowPlaying { get; set; }
    }
}
