// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Numeric data types

float a = 12.5f; //4-bits
double b = 10.9; //8-bits
decimal c = 1.5M; //16-bits (most precise)

int num = 10;
long number = 112;

long num1 = int.MaxValue;
Console.WriteLine(num1);

// strings

string name = "Yuvraj Kumar";
int age = 18;

Console.WriteLine("Hello my name is " + name + " and I am " + age + " years old.");
Console.WriteLine($"Hello my name is {name} and I am {age} years old.");

Console.WriteLine("Hello! I am \"Yuvraj\" ");

char character = 'a';
Console.WriteLine(character);

//bool

bool isEnemy = true;
bool isPlayer = false;

//var

//var is a data type where you dont have to explicitly define the data type, it takes the
// data type according to the value stored in it impliciltly

var myVariable = 10;
var myVariableName = "MyName";
var myVariableFloat = 10.8;

int number1 = 5;
int number2 = 6;

//Compiler works left to right

Console.WriteLine("Number " + number1 + number2); //Number 56
Console.WriteLine(number1 + number2 + " Number"); //11 Number