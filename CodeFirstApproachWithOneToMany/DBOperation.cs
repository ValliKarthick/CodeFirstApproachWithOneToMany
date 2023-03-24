using System;

namespace CodeFirstApproachWithOneToMany
{
    public class DBOperation
    {
        public void InsertDirector(DirectorModel directorModel)
        {
            var movieContext = new MovieContext();
            movieContext.directorModels.Add(directorModel);
            movieContext.SaveChanges();
            Console.WriteLine("Director Added!");
        }

        //public void InsertMovies(MovieModel movieModel)
        //{
        //    var movieContext = new MovieContext();
        //    movieContext.movieModels.Add(movieModel);
        //    movieContext.SaveChanges();
        //    Console.WriteLine("Movie Added!");
        //    Console.ReadLine();
        //}

        //public void FindMovie(int movieId)
        //{
        //    var movieContext = new MovieContext();
        //    MovieModel movieToUpdate = movieContext.movieModels.Find(movieId);
        //}
        public void InsertDirectorsAddress(DirectorAddress directorAddress)
        {
            var movieContext = new MovieContext();
            movieContext.directorAddresses.Add(directorAddress);
            movieContext.SaveChanges();
            Console.WriteLine("Director Address Added!");
            Console.ReadLine();
        }
    }
}
