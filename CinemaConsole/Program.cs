using CinemaLogic;
using System;

namespace CinemaConsole
{
    public class Program
    {
        static CinemaManager manager = new CinemaManager();
        static void Main(string[] args)
            {
                Console.WriteLine("Here is the of available movies!");

                var movie = manager.GetAllMovies();
                if (movie.Count == 0)
                {
                    Console.WriteLine("There are no available movies now!");
                }
                else
                {
                    movie.ForEach(movie =>
                    {
                        Console.WriteLine("{0}, {1}, {2}, {3}, {4}", movie.Title, movie.Director, movie.Year, movie.CategoryId, movie.AvailableTime);
                    });
                }
            }
        
    }
}
