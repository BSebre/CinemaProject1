using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaLogic.Data
{
    public class Categories
    {
       
        public string Comedy { get; set; }
        public string Drama { get; set; }
        public string Horror { get; set; }
        public string Thriller { get; set; }
        public string Animation { get; set; }
        public string Fantasy { get; set; }

        public Categories()
        {
            List<Movies> movies = new List<Movies>();
        }
    }
}
