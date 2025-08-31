using System;

class Program
{
    static void Main(string[] args)
    {
        string empName = "Ram";
        helloName(empName);

        sayHello();

        int sum = add(7, 8);
        Console.WriteLine($"The sum is {sum}");

        int sum2 = add(5, 6, 8);
        Console.WriteLine($"The sum is {sum2}");

        int age = 19;
        string playerName = "Shyam";

        player(playerName, age);
        Console.WriteLine(age); //age is 19 as in player fn only copy of age is incremented

        Console.WriteLine(isPositive(5) + ";" + isPositive(-1));

    }

    static void helloName(string name)
    {
        Console.WriteLine($"Hello, Dear {name}");
    }

    static void sayHello()
    {
        Console.WriteLine("Hello! User");
    }

    static int add(int a, int b)
    {
        int c = a + b;
        return c;
    }

    static int add(int a, int b, int c)
    {
        return a + b + c;
    }

    static void player(string name, int age)
    {
        age++; //here only copy of age is incremented not the actual age
        Console.WriteLine($"Hello! Player {name} with age {age}");
    }

    static bool isPositive(int num){
        return num >= 0;
    }
}