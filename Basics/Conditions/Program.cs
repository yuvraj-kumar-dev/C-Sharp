// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// if, else if, else, switch

if (2 > 1)
{
    Console.WriteLine("Inside if!");
}

bool isPlayer = true;
if (isPlayer)
{
    Console.WriteLine("Player is actuve");
}
else
{
    Console.WriteLine("Player left");
}

//Lazy Evaluation/ Short Circuit

if (true || false && false)
{
    Console.WriteLine("false && false is not evaluated!");
}

if ((true || false) && false)
{
    Console.WriteLine("Hello!");
}
else
{
    Console.WriteLine("true && false = false");
}

//Another way to write if block with single statement

if (false)
    Console.WriteLine("New way to implement if statement");

Console.WriteLine("Hello Viewers!");

int Age1 = 26;

if (Age1 > 18)
{
    Console.WriteLine("Allowed to Vote");
}
else if (Age1 == 18)
{
    Console.WriteLine("Allowed to Vote");
}
else
{
    Console.WriteLine("Not Allowed to Vote");
}

//switch

string name = "Ram";

switch (name)
{
    default:
        Console.WriteLine("Unknown name!");
        break;
        
    case "Ram":
        Console.WriteLine("My name is Ram");
        break;

    case "Shyam":
        Console.WriteLine("My name is Shyam");
        break;
}