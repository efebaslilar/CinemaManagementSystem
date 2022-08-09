using DataAccessLayer;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogicLayer.Manager
{
    public class MovieManager
    {
        MyContext MovieContext = new MyContext();

        public void AddNewMovie(Movie movie)
        {
            try
            {
                MovieContext.Movies.Add(movie);
                MovieContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<Movie> GetAllMovies()
        {
            try
            {
                List<Movie> movies = MovieContext.Movies.ToList();
                return movies;

            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
