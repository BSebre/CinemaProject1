using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaLogic.Data
{
   public class  UserBookings
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }
        public Categories Category { get; set; }
        public DateTime BookedTime { get; set; }
    }
}
