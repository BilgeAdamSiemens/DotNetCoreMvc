using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Movie
    {
        public String Title { get; set; }
        public String Director { get; set; }
        public String Description { get; set; }
        public List<String> Actors { get; set; }
    }
}
