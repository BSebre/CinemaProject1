using CinemaLogic.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CinemaLogic
{
    public class CinemaManager
    {
        private Categories Category{ get; set; }
        private UserBookings User { get; set; }
        public CinemaManager()
        {
            Category = new Categories();
            User = new UserBookings();
        }

        public List<Movies> GetAllMovies()
        {
            //using (var db = new CinemaDB())
            //{
            //    return db.Movie.OrderBy(m => m.AvailableTime).ToList();
            //}
            return null;
        }

        //public List<Movie> GetUsersBookings()
        //{
        //    using (var db = new CinemaDB())
        //    {
        //        return db.
        //    }
        //}
    }
}
