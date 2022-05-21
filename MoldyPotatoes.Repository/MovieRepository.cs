using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoldyPotatoes.Repository
{
    public class MovieRepository
    {
        //Empty constructor: dont really need this yet, but will use it later
        public MovieRepository() {}

        // FAKE DB

        List<Movie> _movieDB = new List<Movie>();


        // CRUD Methods

        // CREATE

        public void AddMovieToDatabase(Movie movie)
        {
            _movieDB.Add(movie); // this is a field

        }

        // READ

        public List<Movie> GetAllMovies()
        {
            return _movieDB;
        }

        public Movie GetMovieByTitle(string MovieTitle)
        {
            foreach (Movie x in _movieDB)
            {
                if (MovieTitle.ToUpper() == x.Title.ToUpper())
                {
                    return x;
                }
            }
            return null;
        }

        public List<Movie> GetMoviesByTitleSearch(string movieTitle)
        {
            List<Movie> movieList = new List<Movie>();

            foreach (Movie x in _movieDB)
            {
                if(x.Title.ToUpper().Contains(movieTitle.ToUpper()))
                {
                    movieList.Add(x);
                }
            }
            return movieList;
        }

        //Avengers 1, 2, 3, 4  and someone types in Avengers, it will display all of those movies 

        // UPDATE


        public void SeedMovieData()
        {
            Movie up = new Movie("Up", "Ben Caplan", Genre.Comedy, Rating.G, 10);
            Movie avengers = new Movie("Avengers", "Nate Humphries", Genre.Action, Rating.PG_13, 10);
            Movie deathToSmoochie = new Movie("Death to Smoochie", "Twila Chandler", Genre.Comedy, Rating.R, 10);
            Movie forrestGump = new Movie("Forrest Gump", "Darryl Jones", Genre.Drama, Rating.PG_13, 10);
            
            Movie[] movieArr = { up, avengers, deathToSmoochie, forrestGump };

            foreach (Movie movie in movieArr)
            {
                AddMovieToDatabase(movie);
            }
        }

        // DELETE

        public bool DeleteMovieFromDatabase(Movie movie)
        {
            int totalMoviesInDB =_movieDB.Count();

            _movieDB.Remove(movie);
            
            if(totalMoviesInDB == _movieDB.Count()) // this should be false, first should be 1 more than second
            {
                return false;
            }
            
            return true;
        }

        //
    }
}

