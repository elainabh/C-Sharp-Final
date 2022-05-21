using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _05_Classes
{
 
 public enum Make { Ford, Hyndai, Toyota }
 public enum Model { Focus, Elantra, Prius }


    public class Car
    {

public Make CarMake { get; set; }
public Model CarModel { get; set; }
public int Year { get; set; }
public Car(Make carMake, Model carModel, int year)
{
    CarMake = carMake;
    CarModel = carModel;
    Year = year;

}
public class Car() {
    
}

    }
    
    public class Movie
    {
        //Class OBJECT

public string Title { get; set; } //adding a property called "Title"
public string DirectorName { get; set; }
public int Stars { get; set; }
public Rating MovieRating { get; set; }
public MovieGenre Genre { get; set; }

//FULL CONSTRUCTOR --shares the name of the class it is in
public Movie(string title, string director, int stars, Rating movieRating, MovieGenre genre)
    {
        Title = title;
        DirectorName = director;
        Stars = stars; 
        MovieRating = movieRating;
        Genre = genre;

    }
//EMPTY CONSTRUCTOR
    public Movie() {

    }
    }
//ENUMS- must be at namespace level
public enum Rating { G, PG, PG_13, R, MA }
public enum MovieGenre { Action, Comedy, Drama, Horror, Romance, RomCom, Thriller, SciFi_Fantasy
 }

}