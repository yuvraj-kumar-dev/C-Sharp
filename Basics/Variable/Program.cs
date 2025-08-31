// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Variable : It is a container to store some type of data in it.

int age = 15;
float marks = 9.5f;

Console.WriteLine("Student with age " + age + " got " + marks + " marks");

// The above line uses string concatenation. Non string values like age and marks are 
// impliciltly converted to strings before concatenation

// We can also declare multiple variables in a single line

int health, money, power;

health = 100;
money = 1000;
power = 10;

Console.Write("Player Stats: ");
Console.WriteLine(health + money + power); //Here the int datatype performed addition


Console.Write("Player Stats: ");
Console.WriteLine("Health: " + health + ", Money: " + money + ", Power: " + power);


health--;
money += 100;
power = power - 1;

Console.WriteLine("Health: " + health + ", Money: " + money + ", Power: " + power);

