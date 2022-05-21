using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoldyPotatoes.Repository;

namespace MoldyPotatoes.ConsoleApp
{
    public interface ICustomConsole
    {
        //Contract that custom console will have to follow
        void EnterATitle();
        void EnterATitleToDelete();
        void EnterDirectorName();
        void EnterStars();
        void GenreSelectionMenu();
        string GetUserInput();
        int GetUserInputInt();
        void PressAnyKeyToContinue();
        void PrintMainMenu();
        void PrintMovie(Movie film);
        void PrintMovies(List<Movie> film);
        void RatingSelectionMenu();
        void Search();
        void MovieSuccessfullyDeleted(Movie film);
        void SomethingWentWrong();
        void MovieNotFound(string movieTitle);
        void ExitMessage();

    }
}