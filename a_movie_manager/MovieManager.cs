using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a_movie_manager
{
    internal class MovieManager
    {
        protected List<Movie> Movies;
        public MovieManager()
        {
            Movies = [];
        }
        public MovieManager(List<Movie> movies)
        {
            Movies = movies;
        }
        public void AddMovie(Movie movie)
        {
            Movies.Add(movie);
        }
        public void RemoveMovie(Movie movie)
        {
            Movies.Remove(movie);
        }
        public void Clear()
        {
            Movies.Clear();
        }
        public List<Movie> GetMovies() {
            return Movies;
        }
        public Movie GetMovie(int id)
        {
            return Movies[id];
        }
    }
}
