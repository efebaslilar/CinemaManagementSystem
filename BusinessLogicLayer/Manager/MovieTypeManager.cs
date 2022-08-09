using DataAccessLayer;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogicLayer.Manager
{
    public class MovieTypeManager
    {
        MyContext MovieTypeContext = new MyContext();
        public void AddNewMovieType(MovieType movieType)
        {
            try
            {
                MovieTypeContext.MovieTypes.Add(movieType);
                MovieTypeContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<MovieType> GetAllMovieTypes()
        {
            try
            {
                List<MovieType> movieTypes = new List<MovieType>();
                movieTypes = MovieTypeContext.MovieTypes.ToList();
                return movieTypes;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
