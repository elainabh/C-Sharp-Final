//OPERATORS 

//Arithmetic Operators


//Addition
int intA = 22;
int intB = 13;

int sum = intA + intB;
sum += 7; //takes whatever sum is and adds 7

Console.WriteLine(sum);

//Subraction
int difference = intA - intB;
difference -= -7; //takes whatever sum is and subtracts -7
Console.WriteLine(difference);

//Multiplication
int product = intA * intB;
product *= 2; //takes whatever product is and multiplies by 2;
Console.WriteLine(product);

//Division
int quotient = intA / intB;
Console.WriteLine(quotient); // outcome is 1 because ints can't have demical places

//Modulus - get the remainder
int remainder = intA % intB;


//DATES
DateTime today = DateTime.Now;
DateTime someOtherDay = new DateTime(1978, 1, 1);
TimeSpan timeSpan = today - someOtherDay;

Console.WriteLine(timeSpan); // outcome is 16188.18 (days) : 52.12.4945219 (hours, minutes, seconds)

//can parse these into a different format; takes TimeSpan in as a parameter & converts it into something readable

//COMPARISON OPERATORS

int age = 25;
string userName = "Harry";

bool equals = age == 41;
bool isCorrectUserName = userName == "Lloyd";

bool notEqual = age != 30; //returns true, uses not equal sign

// || OR

// && AND

bool trueValue = true;
bool falseValue = false;

bool trueAndTrue = trueValue && falseValue; //false because this is a bool and both must be true for this to be true

Console.WriteLine(trueAndTrue);

bool trueOrTrue = trueValue || falseValue;

Console.WriteLine(trueOrTrue); //true because one is true 

int xyz = 10;
int abc = 12; 

if(xyz > 9 && abc < 14) {
    Console.WriteLine(true);
}

//CONDITIONALS 

// IF STATEMENTS

bool isHungry = true;

if (isHungry) 
{
    Console.WriteLine("Eat something.");
}

if (isHungry && age >= 21)
{
    Console.WriteLine("Eat cus ur old nuff.");
}

//IF ELSE STATEMENT 

bool tpsReportsAreFinished = false;

if(tpsReportsAreFinished)
{
    Console.WriteLine("You don't have to work on Saturday.");
}
else 
{
    Console.WriteLine("We're gonna need you to come in on Saturday");
}

//ELSE IF 

if(tpsReportsAreFinished)
{
    Console.WriteLine("You don't have to work on Saturday.");
}
else if (age >= 21)
{
    Console.WriteLine("Don't gotta work on Sat...have fun on St Patty's");
}
else 
{
    Console.WriteLine("We're gonna need you to come in on Saturday");
}


//nested if else statement
tpsReportsAreFinished = false;

bool bossDoesntCare = true;

if(tpsReportsAreFinished)
{
    Console.WriteLine("You dont gotta come in.");
}
else
{
    if(bossDoesntCare)
    {
        Console.WriteLine("You dont gotta come in");
    }
    else
    {
        Console.WriteLine("You gotta come in");
    }
}

//SWITCH CASES

int input = 1;

switch (input)
{
    case 1:
    Console.WriteLine("It's a ONE");
        break;
    case 2:
    Console.WriteLine("It's a TWO");
        break;
    case 3:
    Console.WriteLine("It's a THREE");
        break;
    default:
    Console.WriteLine("I dunno"); //default is a catch-all
        break;
}

//TERNARIES

// bool VARIABLE = CONDITIONAL ? OUTPUT_IF_TRUE : OUTPUT_IF_FALSE;

age = 35;

bool canDrinkAlcohol = (age >= 21) ? true : false;

string reaction = (age >= 21) ? "hooray" : "bummer";