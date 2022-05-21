// LOOPS

//TYPES OF LOOPS: FOR, WHILE, FOREACH, WHILE, DO-WHILE

int total = 1;

// while (total != 8) //while loops condition must be able to evaluate to TRUE or FALSE
// {
//     Console.WriteLine("Just keep swimming...");
//     Console.ReadKey();
//     total += 1;
// }

bool isRunning = true;

total = 1;

while (isRunning)
{
    Console.WriteLine("Just keep swimming");
    
    if (total == 4)
    {
        isRunning = false;
    }

    total++;
}

//DO WHILE - will always execute at least once, then will check to see if we do it again; WHILE loops doesnt have to execute at least once

int iterator = 0;

do
{
    Console.WriteLine("Hello world");
    iterator++;
}
while(iterator < 5);

//FOR LOOP

total = 10; 

for (int i = 0; i < total; i ++)
{
    Console.WriteLine("Fortnite victory royale");
}

string [] students = { "Harry", "Lloyd", "Thelma", "Louise", "Pippin", "Merry" };

for (int i = 0; i < students.Length; i++)
{
    Console.WriteLine($"Welcome to EFA, {students[i]}");
}

List<string> roster =  new List<string>() { "Harry", "Lloyd", "Thelma", "Louise", "Pippin", "Merry" };

for (int i = 0; i < roster.Count; i++)
{
    Console.WriteLine($"Welcome to EFA, {roster[i]}");
}

//FOREACH LOOP -- do something to each item in a list

foreach (string name in roster)
{
    foreach(char x in name)
    {
        Console.Write(char.ToUpper(x));
    }
        Console.Write("\n");
}
