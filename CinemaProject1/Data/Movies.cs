using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaLogic.Data
{
    public class Movies
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }
        public Categories Category { get; set; }
        public DateTime AvailableTime { get; set; }

        public Movies()
        {

        }
    }
}
