using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class User
    {
        public int userId { get; set; }
        [Required]
        public string userName { get; set; }
        [Required]
        public string firstName { get; set; }
        [Required]
        public string lastName { get; set; }
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public DateTime birthDate { get; set; }
        [Required]
        public string gender { get; set; }

        public List<Movie> movies { get; set; }
        public List<Comment> comments { get; set; }
    }
}
