using DailyChallenges;

ChallengeRepository _cry = new ChallengeRepository();

    //         string team1 = "Good Team";
    //         string team2 = "Bad Team";
    //         int score1 = 600;
    //         int score2 = 3;
    //         _cry.whoWon(team1, team2, score1, score2);

    // Console.WriteLine(_cry.whoWon(team1, team2, score1, score2));


// string toSpongebob = "convert this text";
// for (int i = 0; i < toSpongebob.Length; i++) {
//        foreach(char in toSpongebob) { if (i % 2 == 0) {
//                 string.ToUpper(toSpongebob);
//         }
//         }
// }

// Method called SpongebobCaser()
//Parameter of type string
//strings are just arrays of chars
// Loop through our array of chars and capitalize every other char and lowercase the other chars
//Foreach loop through our array of chars
//Based on the index being odd or even, we will capitalize or lowercase the char
//Then return the string 

//Instantiate a variable type string output = "nothing"
//Return output

// string input = "can we fix it? yes we can!!!";

// string output =_cry.SpongebobCaser(input);

// Console.WriteLine(_cry.SpongebobCaser(output));

//Write a method that takes in a list of floats that represent measurements in miles and returns a list of those values in kilometers, but excludes measurements under 0.5m/0.8km. Print each measurement to the console.

//1.) write a method that contains float measurements in the ChallengeRepository.cs
//2.) create instance of the class and store it in a variable in Program.cs
//3.) float array in Program.cs
//4.) use a foreach loop to loop over each float in the array to convert them to kilometers
//5.) if else statement to apply conversion to the applicable numbers
//6.) create a new array to add the converted floats to
//7.) print the new array to console
//8.) initialize in Program.cs




// List<float> listOfFloats = new List<float>(){ .4f, 1f, 2f, 3f, 4f };

// Console.WriteLine(_cry.KilometerConverter(listOfFloats));

// List<float> kmlist = _cry.KilometerConverter(listOfFloats);

// foreach (float x in kmlist)
// {
//     Console.WriteLine(x);
// }

//Write a method that asks the user to choose between either A,B, or C. Based off of their choice print "alligator", "biscuit", or "chihuahua" to the console. If they don't choose A, B, or C print "spaghetti" to the console.



//Create a method with access modifier public and datatype string, create a parameter with a datatype of char in ChallengeRepository.cs called RandomChoice(char x)

// Create a private void method called PrintMainMenu() in Program.cs that will print to console "What do you choose? /n A. /n B. /n C."

//Create another method called GetInputFromUser() in Program.cs that will get input from user, returning a Console.ReadLine(); and convert .toUpper

// Save user input from Console.Readline(); into char userInput variable

//pass a switch case through RandomChoice(char x) with case 'A' returning "alligator", case 'B' returning "biscuit", case 'C' returning "chihuahua", and default returning "spaghetti" 

// Initialize the RandomChoice(char x) in in Program.cs by passing userInput through it and printing the result to console 

// char userInput = ' ';
// char userChoice = _cry.PrintMainMenu(userInput);

// string userOneAnswer = Console.ReadLine();
// string userTwoAnswer = Console.ReadLine();
// string userResponse = Console.ReadLine();
// Console.WriteLine(_cry.RockPaperScissors(userOneAnswer, userTwoAnswer));
// Console.WriteLine(_cry.HangMan(userResponse));

List<int> numbersList = new List<int>() { 5, 6, 1, 9, 2, 8, };

Dictionary<string, decimal>_dict = _cry.MeanMedianMode(numbersList);

Console.WriteLine("MEAN - " + _dict["mean"]);
Console.WriteLine("MEDIAN - " + _dict["median"]);
Console.WriteLine("MODE - " + _dict["mode"]);

numbersList.Sort();

int[] allNums = { 1, 2, 3, 4, 5 };
int index = 0;
while (index <= 5)
{
    Console.WriteLine($"Last index {allNums[index]}"); index++;
}