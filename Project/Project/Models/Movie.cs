using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public class Movie
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Genre { get; set; }

        public int Duration { get; set; }

        public int Year { get; set; }
    }
}