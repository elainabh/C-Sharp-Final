// VALUE TYPES
// Value types are stored in the STACK -- need to know the difference between STACK and HEAP for interview questions (long strings of data go on the heap, smaller data types go on the stack)

//BOOLS AND CHARS
// These also go on the STACK

bool isDeclared; // this is just declaring a variable, not assigning it a value -- SEMICOLONS are NEVER OPTIONAL
isDeclared = true; // assigning a value to an existing variable

bool isDeclaredAndInitialized = true;

char character = 'a'; // Single Quotes for chars in C# --ALWAYS
char symbol = '?';
char number = '7';
char space = ' ';
char specialCharacter = '\n'; //this is the new line character


// WHOLE NUMBERS

byte age = 23; //bytes cannot be negative and max out at 255
int someNumber = 12; //No quotes or suffixes for ints/ whole numbers
int max = 2147483647; 
long bigWholeNumber = 9223372036854775807;
sbyte negativeAge = -20; //if we need a negative small number, this is signed
uint unsignedInt = 28; //similar to int, this is unsigned
short shortExample = 3245;


// if you have a choice, use the data type that will use the least amount of memory


//FLOATING POINT NUMBERS - not whole numbers 

//floats, doubles, decimals

//FLOATING POINT NUMBERS USE SUFFIXES

float floatExample = 1.0456345f;
double doubleExample = 212.312093d;
decimal decimalExample = 2.034945m;

float x = 1.123456789123456789123456789123456789123456789f; //7 decimal places
double y = 1.123456789123456789123456789123456789123456789d; //17 decimal palces
decimal z = 1.123456789123456789123456789123456789123456789m; //28 decimal places

// Console.WriteLine(x);
// Console.WriteLine(y);
// Console.WriteLine(z);

// enum PastryType { cake, cupcake, eclaire, croissant };


// DATE VALUE TYPES

// DateTime today = DateTime.Today;
// DateTimeOffset today = DateTimeOffset.Today; // deals with time zones

//REFERENCE TYPES - these are stored on the HEAP

string firstName = "Bob";
string lastName = "Darryl";

string concatFullName = firstName + " " + lastName;
string compositeFullName = string.Format("Hi my name is {0} {1}", firstName, lastName);
string interpolFullName = $"{firstName} {lastName}";

Console.WriteLine(concatFullName);
Console.WriteLine(compositeFullName);
Console.WriteLine(interpolFullName);

string[] stringArray = { "hello", "world", "!" };

Console.WriteLine(stringArray[0]); //returns hello


//LISTS--creates a new list and returning it

List<string> listOfStrings = new List<string>(); 
listOfStrings.Add("dog");
listOfStrings.Remove("dog");

List<int> listOfInts = new List<int>();


//QUEUES and DICTIONARIES

Queue<string> firstInFirstOut = new Queue<string>();
//called firstInFirstOut because it is a "queue"; we have a line, so as we add things to the line, we can pop things out of the queue. So if we have some kind of functionality so we can add stuff up here or remove things down there...

Dictionary<int, string> keyAndValue = new Dictionary<int, string>(); //USE THIS TO IMPRESS TREVOR LMAO
//int is the key, string is the value
//select 1, 2, or 3, and it grabs what has the corresponding value

keyAndValue.Add(7, "Agent");

Console.WriteLine(keyAndValue[7]); //will go find the 7 and print value, which is Agent



Console.WriteLine(10 % 2);
Console.WriteLine("5 + 2");
Console.WriteLine("5" + "2");












