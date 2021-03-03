using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class MovieViewModel
    {
        public ApiMovieDetail movie { get; set; }

        public dynamic watchProviders { get; set; }
        public dynamic actors { get; set; }
        public dynamic trailers { get; set; }
        public dynamic relatedMovies { get; set; }

        public Movie dbMovie { get; set; }

        public List<Comment> comments { get; set; }

        public Comment comment { get; set; }
    }
}
