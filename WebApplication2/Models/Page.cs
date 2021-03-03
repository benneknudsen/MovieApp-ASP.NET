using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Page
    {
        public int page { get; set; }
       public List<ApiMovie> results { get; set; }
    }
}
