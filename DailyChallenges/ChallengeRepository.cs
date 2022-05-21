using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq;

namespace DailyChallenges
{
    public class ChallengeRepository
    {
//         public char PrintMainMenu (char x)
// {
//     Console.WriteLine("What do you choose? \nA: \nB: \nC:");
//     char input = Char.ToUpper(Console.ReadKey().KeyChar);
//     switch (input)
//     {
//         case 'A': 
//         Console.WriteLine("\n alligator");
//         return input;
//         case 'B': 
//         Console.WriteLine("\n biscuit");
//         return input;
//         case 'C': 
//         Console.WriteLine("\n chihuahua"); 
//         return input;
//         default:
//         Console.WriteLine("\n spaghetti");
//         return input;
//     }
// }

//         public List<float> KilometerConverter(List<float> input)
//         {
        
//             List<float> emptyList = new List<float>();

//             foreach(float x in input)
//             {
//                 if (x > .497f)
//                 {
//                     emptyList.Add(x * 1.609344f); 
//                 }

//             }
//                 return emptyList;


//         }
//         public string whoWon(string team1, string team2, int score1, int score2)
//         {

//             if(score1 == score2)
//             {
//                 return $"{team1} and {team2} tied";
//             }
//             else if(score1 > score2)
//             {
//                 return $"{team1} won";
//             }
//             else 
//             {
//                 return $"{team2} won";
//             }
//         }

//         // string input = "Hello World.";

//         public string SpongebobCaser(string input) 
//         {
//             string output = "";

//             foreach(char x in input) 
//             { 
//                     if (input.IndexOf(x) % 2 == 0)
//                     {
//                             output += char.ToUpper(x);
//                     }
//                     else 
//                     {
//                             output += char.ToLower(x);
//                     }
//             }

//             return output;
//         }

//ROCK-PAPER-SCISSORS CHALLENGE
// Write a method that takes in two parameters of type string. The two strings will represent a choice of "rock", "paper", or "scissors" from PlayerONE and PlayerTWO. Print out which player wins or if they tied. Your method should be able to handle weird capitalization of "RoCk", "pAPeR", "scIssOrS".

// public void RockPaperScissors()
// {
// Console.WriteLine("Player one, choose rock, paper, or scissors.");
// Console.ReadLine();
// string userOne = Console.ReadLine();
// Console.Clear();
// Console.WriteLine("Player two, choose rock, paper, or scissors.");
// Console.ReadLine();
// string userTwo = Console.ReadLine();
// if (userOne.ToLower() == "rock" && userTwo.ToLower() == "rock")
// {
//     Console.Clear();
//     Console.WriteLine("You have tied");
// }
// else if (userOne.ToLower() == "rock" && userTwo.ToLower() == "scissors")
// {
//     Console.Clear();
//     Console.WriteLine("Player one has won");
// }
// else if (userOne.ToLower() == "rock" && userTwo.ToLower() == "paper")
// {
//     Console.Clear();
//     Console.WriteLine("Player two has won");
// }
// else if (userOne.ToLower() == "scissors" && userTwo.ToLower() == "rock")
// {
//     Console.Clear();
//     Console.WriteLine("Player two has won.");
// }
// else if (userOne.ToLower() == "paper" && userTwo.ToLower() == "rock")
// {
//     Console.Clear();
//     Console.WriteLine("Player one has won");
// }




// HANGMAN CHALLENGE
// Write a method that takes a parameter of type string, and prints out _underscores_ and spaces for representing the string in a game of hangman.
// Example:
// "I love coding" would print "_   _ _ _ _   _ _ _ _ _ _"
// public void HangMan()

// {

// Console.WriteLine("Type in a word...");
// Console.ReadLine();
// string userInput = Console.ReadLine();
// string underScore = " ";
// foreach (char x in userInput)
// {
//     for (int i = 0; i >= userInput.Length; i++)
//     {
// if (x == ' ')
// {
//     underScore += " ";
// }
// else 
// {
//     underScore += "_";
// }
// }
// Console.WriteLine(underScore);
// }
// }
//     }

// }


//01
        //Write a method that each complete the following tasks:

        //Take in FOUR parameters: 2 strings and 2 ints. The strings being the names of two different soccer teams, and the ints being the teams' scores.

        //Method should return a string of either "{teamOne} won." or "{teamTwo} won." or "{teamOne} and {teamTwo} tied".

        //Invoke each method in Program.cs and print the returned results to the console.


// 1. McDonald's hires you to create their new menu app. Create a Class object for a McDonald's value meal.


public class McDonaldsValueMeal // have to make a class on white board assessment, and properties, full constructor, and empty constructor
{

public string MealItem { get; set; }

public decimal ItemCost { get; set; }

public int CalorieCount { get; set; }

}

public ValueMeal()
{

}



// 2. Write a method that takes in your birthday and returns how many days you have been alive.

public void TimeAliveInDays (string birthDay)

{
    DateTime convertBirthday = Convert.ToDateTime(birthDay);
    TimeSpan getAge = DateTime.Now.Subtract(convertBirthday);
    Console.WriteLine("You are" + getAge.TotalDays + "days old");
}

// 3. Write a method that takes in a list of integers, and then returns a dictionary with three key/value pairs that represent the mean, median, and mode. You can write multiple methods to help out.



public Dictionary<string, decimal> MeanMedianMode(List<int> numbersList)
{
    //new dictionary to return
    //mean - average
    //median - in middle
    //mode - most common

    // sort numberList
    // variables of int mean/median/mode = values of dict
    decimal mean = Mean(numberList);
    decimal median = Median(numbersList);
    decimal mode = Mode(numbersList);
    // calculate mean, median, mode
    // add mean, median, mode to dict with keys(string "mean "median" "mode")
    // return the dictionary

    meanMedianModeDict.Add("mean", mean);
    meanMedianModeDict.Add("median", median);
    meanMedianModeDict.Add("mode", mode);






Dictionary<string, decimal> meanMedianModeDict =  new Dictionary<string, decimal>();

numbersList.Sort(); // sort has a return type of void, doesnt return anythinh; just sorts it




return meanMedianModeDict();

}

private decimal Mean(List<int> numbersList)
{
    decimal mean = numbersList.Count > 0 ? (decimal)(numbersList.Average()) : 0.0m; //throwing decimal in front is a "cast" that helps convert 
    return mean;
}

private decimal Median(List<int> numbersList)
{
    numbersList.Sort();
    decimal median;

    if (numbersList.Count % 2 != 0)
    {
        median = numbersList[((numbersList.Count) / 2)];
    }
    else
    {
        int x = numbersList[((numbersList.Count / 2 ) -1)];
        int y = numbersList[((numbersList.Count / 2))];

        median = (x + y) / 2;
    }

    return median;
}
private decimal Mode(List<int> numbersList)
{
    int mode = numbersList.GroupBy(v => v)
                .OrderByDescending(g => g.Count())
                .First()
                .Key;
    return mode;
}

int[] allNums = { 1, 2, 3, 4, 5 };
int index = 0;
while (index <= 5)
{
    Console.WriteLine($"Last index {allNums[index]}"); index++;
}


}
}